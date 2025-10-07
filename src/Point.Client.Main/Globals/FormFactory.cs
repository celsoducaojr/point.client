using Point.Client.Main.Forms;

namespace Point.Client.Main.Globals
{
    public static class FormFactory
    {
        private static List<Form> _forms = [];

        public static T GetFormDialog<T>() where T : Form, new()
        {
            // Try to find an existing form of type T
            var existingForm = _forms.OfType<T>().FirstOrDefault();

            if (existingForm != null && !existingForm.IsDisposed)
            {
                existingForm.StartPosition = FormStartPosition.Manual;

                return existingForm;
            }

            // Remove disposed forms
            _forms.RemoveAll(f => f.IsDisposed);

            // Create a new instance of the form
            T newForm = new T();
            _forms.Add(newForm);

            return newForm;
        }

        public static T GetForm<T>() where T : Form, new()
        {
            // Try to find an existing form of type T
            var existingForm = _forms.OfType<T>().FirstOrDefault();

            if (existingForm != null && !existingForm.IsDisposed)
            {
                existingForm.WindowState = FormWindowState.Maximized;
                existingForm.Activate();

                return existingForm;
            }

            // Remove disposed forms
            _forms.RemoveAll(f => f.IsDisposed);

            // Create a new instance of the form
            T newForm = new T();
            _forms.Add(newForm);

            return newForm;
        }

        #region Form Loading

        private static Dictionary<string, frmLoading> _loadingForms = [];
        public static void ShowLoadingForm(Form owner, string? message = null)
        {
            var form = new frmLoading();
            _loadingForms[owner.Name] = form;
            form.SetMessage(message);
            form.Show(owner);
        }

        public static void CloseLoadingForm(Form owner)
        {
            if (_loadingForms.TryGetValue(owner.Name, out frmLoading? form))
            {
                form?.Close();
                _loadingForms.Remove(owner.Name);
            }
        }

        #endregion
    }
}
