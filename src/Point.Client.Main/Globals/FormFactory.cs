namespace Point.Client.Main.Globals
{
    public static class FormFactory
    {
        private static List<Form> _forms = [];

        public static T GetForm<T>() where T : Form, new()
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
    }

}
