using AppShoppingCenter.Models;
using AppShoppingCenter.Services; // Adicione este using
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppShoppingCenter.ViewModels.Tickets;

public partial class ListPageViewModel : ObservableObject
{
    [ObservableProperty]
    private List<Ticket> tickets;

    public ListPageViewModel()
    {

        var service = new TicketService();
        Tickets = service.GetTickets(0);
    }
}