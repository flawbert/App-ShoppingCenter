using AppShoppingCenter.Models;
using AppShoppingCenter.Storages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppShoppingCenter.ViewModels.Tickets;

[QueryProperty(nameof(Ticket), "ticket")]
public partial class PayPageViewModel : ObservableObject
{
    private Ticket ticket;
    private double HourValue = 0.07;

    public Ticket Ticket
    {
        get { return ticket; }
        set
        {
            // Proteção contra valor nulo
            if (value == null) return;

            GenerateDateOutAndTolerance(value);
            GeneratePrice(value);
            SetProperty(ref ticket, value);
        }
    }

    [ObservableProperty]
    private string pixCode = "123456789009876543210...";

    [RelayCommand]
    private async Task CopyAndPaste()
    {
        await Clipboard.Default.SetTextAsync(PixCode);

        // Feedback visual ou espera (opcional, 10s pode ser muito longo para teste, reduza se necessário)
        await Task.Delay(1000);

        var storage = App.Current.Handler.MauiContext.Services.GetService<TicketPreferenceStorage>();
        storage.Save(Ticket);

        var param = new Dictionary<string, object>
        {
            { "ticket", Ticket }
        };

        // CORREÇÃO: Usar o nome absoluto da rota registrado no AppShell
        // Em vez de "../result", usamos "TicketResult"
        await Shell.Current.GoToAsync("TicketResult", param);
    }

    private void GenerateDateOutAndTolerance(Ticket ticket)
    {
        var rd = new Random();
        var hour = rd.Next(0, 12);
        var minute = rd.Next(0, 60);

        ticket.DateOut = ticket.DateIn.AddHours(hour).AddMinutes(minute);
        ticket.DateTolerance = ticket.DateOut.AddMinutes(30);
    }

    private void GeneratePrice(Ticket ticket)
    {
        var dif = ticket.DateOut.Ticks - ticket.DateIn.Ticks;
        var difTS = new TimeSpan(dif);

        ticket.Price = difTS.TotalMinutes * HourValue;
    }
}