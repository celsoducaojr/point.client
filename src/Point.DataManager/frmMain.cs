using Dapper;
using MySql.Data.MySqlClient;
using Point.DataManager.Dto;

namespace Point.DataManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Select CSV File";
                dialog.Filter = "CSV Files (*.csv)|*.csv";
                dialog.DefaultExt = "csv";
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;
                dialog.Multiselect = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtFile.Text = dialog.FileName;
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (txtFile.Text.Trim().Length == 0 || !File.Exists(txtFile.Text))
            {
                MessageBox.Show("Please select a valid CSV file.",
                    "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Task.Run(() =>
            {
                var formTitle = this.Text;
                this.UseWaitCursor = true;
                this.Invoke(() =>
                {
                    foreach (Control control in this.Controls) control.Enabled = false;
                });

                var itemDtos = new List<ItemDto>();
                var lines = File.ReadAllLines(txtFile.Text);
                foreach (var line in lines.Skip(1))
                {
                    var values = line.Split(',');
                    itemDtos.Add(new ItemDto
                    {
                        Name = values[0],
                        Category = values[1],
                        Unit = values[2],
                        Prices = new List<decimal>
                        {
                            Math.Round(decimal.Parse(values[3]), 2),
                            Math.Round(decimal.Parse(values[4]), 2)
                        }
                    });
                }

                var connectionString = Program.Configuration["ConnectionStrings"].ToString();
                using (var db = new MySqlConnection(connectionString))
                {
                    db.Open();
                    using (var tranx = db.BeginTransaction())
                    {
                        try
                        {
                            var categories = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                            var units = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                            var items = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                            var itemUnits = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                            foreach (var i in itemDtos)
                            {
                                this.Invoke(() =>
                                {
                                    this.Text = "Processing: " + i.Name;
                                });

                                if (!categories.ContainsKey(i.Category))
                                {
                                    var existingId = db.ExecuteScalar<int?>("SELECT Id FROM categories WHERE Name = @Name", 
                                        new { Name = i.Category }, tranx);
                                    if (existingId.HasValue)
                                    {
                                        categories[i.Category] = existingId.Value;
                                    }
                                    else
                                    {
                                        var categoryId = db.ExecuteScalar<int>("INSERT INTO categories (Name) VALUES (@Name); SELECT LAST_INSERT_ID();", 
                                            new { Name = i.Category }, tranx);
                                        categories[i.Category] = categoryId;
                                    }   
                                }

                                if (!units.TryGetValue(i.Unit, out int unitId))
                                {
                                    var existingId = db.ExecuteScalar<int?>("SELECT Id FROM units WHERE Name = @Name", 
                                        new { Name = i.Unit }, tranx);
                                    if (existingId.HasValue)
                                    {
                                        units[i.Unit] = existingId.Value;
                                        unitId = existingId.Value;
                                    }
                                    else
                                    {
                                        unitId = db.ExecuteScalar<int>("INSERT INTO units (Name) VALUES (@Name); SELECT LAST_INSERT_ID();", 
                                            new { Name = i.Unit }, tranx);
                                        units[i.Unit] = unitId;
                                    }  
                                }

                                if (!items.TryGetValue(i.Name, out int itemId))
                                {
                                    var existingId = db.ExecuteScalar<int?>("SELECT Id FROM items WHERE Name = @Name", 
                                        new { Name = i.Name }, tranx);
                                    if (existingId.HasValue)
                                    {
                                        items[i.Name] = existingId.Value;
                                        itemId = existingId.Value;
                                    }
                                    else
                                    {
                                        string insertSql = @"INSERT INTO items (Name, CategoryId, Created, LastModified) 
                                                     VALUES (@Name, @CategoryId, Now(), Now()); 
                                                     SELECT LAST_INSERT_ID();";
                                        itemId = db.ExecuteScalar<int>(insertSql, new
                                        {
                                            Name = i.Name,
                                            CategoryId = categories[i.Category]
                                        }, tranx);
                                        items[i.Name] = itemId;
                                    }
                                }

                                var itemUniKey = $"{itemId}_{unitId}";
                                if (!itemUnits.TryGetValue(itemUniKey, out int itemUnitId))
                                {
                                    var existingId = db.ExecuteScalar<int?>("SELECT Id FROM itemunits WHERE ItemId = @ItemId AND UnitId = @UnitId", 
                                        new { ItemId = itemId, UnitId = unitId }, tranx);
                                    if (existingId.HasValue)
                                    {
                                        itemUnits[itemUniKey] = existingId.Value;
                                        itemUnitId = existingId.Value;
                                    }
                                    else
                                    {
                                        string insertSql = @"INSERT INTO itemunits (ItemId, UnitId, Created, LastModified, isDeleted) 
                                                     VALUES (@ItemId, @UnitId, Now(), Now(), false); 
                                                     SELECT LAST_INSERT_ID();";
                                        int newId = db.ExecuteScalar<int>(insertSql, new
                                        {
                                            ItemId = itemId,
                                            UnitId = unitId
                                        }, tranx);
                                        itemUnits[itemUniKey] = newId;
                                        itemUnitId = newId;
                                        itemUnits[itemUniKey] = newId;
                                        itemUnitId = newId;
                                    }
                                }

                                for (int x = 1; x <= 2; x++)
                                {
                                    var priceSql = "SELECT Id FROM prices WHERE ItemUnitId = @ItemUnitId AND PriceTypeId = @PriceTypeId";
                                    var id = db.ExecuteScalar<int?>(priceSql, new { ItemUnitId = itemUnitId, PriceTypeId = x }, tranx);
                                    if (!id.HasValue)
                                    {
                                        priceSql = @"INSERT INTO prices (Amount, ItemUnitId, PriceTypeId) 
                                                     VALUES (@Amount, @ItemUnitId, @PriceTypeId); 
                                                     SELECT LAST_INSERT_ID();";
                                        db.Execute(priceSql, new
                                        {
                                            Amount = i.Prices[x - 1],
                                            PriceTypeId = x,
                                            ItemUnitId = itemUnitId
                                        }, tranx);
                                    }
                                }
                            }

                            tranx.Commit();

                            this.Invoke(() =>
                            {
                                this.Text = formTitle;
                                this.UseWaitCursor = false;

                                MessageBox.Show($"Import successful! Processed {lines.Length - 1} items.",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                foreach (Control control in this.Controls) control.Enabled = true;
                            });
                        }
                        catch (Exception ex)
                        {
                            tranx.Rollback();

                            this.Invoke(() =>
                            {
                                this.Text = formTitle;
                                this.UseWaitCursor = false;

                                MessageBox.Show("An error occurred while processing the data.\n\n" + ex.Message,
                                    "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                foreach (Control control in this.Controls) control.Enabled = true;
                            });

                            return;
                        }
                    }
                    db.Close();
                }
            });

        }

    }
}
