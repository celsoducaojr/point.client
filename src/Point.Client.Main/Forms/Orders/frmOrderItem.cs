using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using Point.Client.Main.Globals;
using static Point.Client.Main.Globals.RecordStatus;

namespace Point.Client.Main.Forms.Orders
{
    public partial class frmOrderItem : Form
    {
        private bool _isFirstLoad;

        private SearchItemCriteriaDto? _searchItemDto;
        private int _currentPage;
        private int _currentTotalPages;
        private int _currentPageSize;

        private List<PriceType>? _currentPriceTypes;

        private DateTime? _categoryLastUpdate;
        private DateTime? _tagLastUpdate;

        private readonly ItemService _itemService;
        private readonly ItemUnitService _itemUnitService;
        private readonly PriceTypeService _priceTypeService;

        public frmOrderItem()
        {
            InitializeComponent();

            _isFirstLoad = true;

            _searchItemDto = null;
            _currentPage = 1;
            _currentTotalPages = 0;
            _currentPageSize = FormConstants.Pagination.PageSizes.ElementAtOrDefault(0);

            _itemService = ServiceFactory.GetService<ItemService>();
            _itemUnitService = ServiceFactory.GetService<ItemUnitService>();
            _priceTypeService = ServiceFactory.GetService<PriceTypeService>();

            cmbPageSize.Items.AddRange(FormConstants.Pagination.PageSizes.Cast<object>().ToArray());
        }

        private async void frmOrderItem_Load(object sender, EventArgs e)
        {
           
        }

     
    }
}
