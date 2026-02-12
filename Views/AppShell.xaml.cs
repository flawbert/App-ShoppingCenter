namespace AppShoppingCenter
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("stores/detail", typeof(Views.Stores.DetailPage));
            Routing.RegisterRoute("restaurants/detail", typeof(Views.Stores.DetailPage));
            Routing.RegisterRoute("cinemas/detail", typeof(Views.Cinemas.DetailPage));

            Routing.RegisterRoute("TicketsPay", typeof(Views.Tickets.PayPage));
            Routing.RegisterRoute("TicketsList", typeof(Views.Tickets.ListPage));
            Routing.RegisterRoute("TicketResult", typeof(Views.Tickets.ResultPage));
            Routing.RegisterRoute("TicketsCamera", typeof(Views.Tickets.CameraPage));
        }
    }
}
