using AppShoppingCenter.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Tickets;

public partial class ScanPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string ticketNumber;

    private bool isNavigating = false;

    [RelayCommand]
    private async Task Scan()
    {
        if (isNavigating) return;

        try
        {
            isNavigating = true;
            await Shell.Current.GoToAsync("TicketsCamera");
        }
        finally
        {
            isNavigating = false;
        }
    }

    [RelayCommand]
    private async Task CheckTicketNumber()
    {
        if (isNavigating) return;

        // Remove espaços para verificação e busca
        var currentText = TicketNumber?.Replace(" ", "") ?? "";

        if (currentText.Length < 12) return;

        try
        {
            isNavigating = true;

            await Task.Delay(300);

            var service = new TicketService();

            // CORRIGIDO: Passando 'currentText' (limpo) em vez de 'TicketNumber' (com espaços)
            var ticket = service.GetTicket(currentText);

            if (ticket == null)
            {
                await MainThread.InvokeOnMainThreadAsync(async () =>
                {
                    await App.Current.MainPage.DisplayAlert("Aviso", "Ticket não encontrado", "OK");
                });
                TicketNumber = string.Empty;
                return;
            }

            var param = new Dictionary<string, object>()
            {
                { "ticket", ticket }
            };

            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Shell.Current.GoToAsync("TicketsPay", param);
            });

            TicketNumber = string.Empty;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Erro na navegação: {ex.Message}");
        }
        finally
        {
            await Task.Delay(500);
            isNavigating = false;
        }
    }

    [RelayCommand]
    private async Task List()
    {
        if (isNavigating) return;
        isNavigating = true;
        try
        {
            await Shell.Current.GoToAsync("TicketsList");
        }
        finally
        {
            isNavigating = false;
        }
    }
}