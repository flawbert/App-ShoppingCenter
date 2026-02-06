namespace AppShoppingCenter
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("detail", typeof(Views.Stores.DetailPage));
        }
    }
}
