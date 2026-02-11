using AppShoppingCenter.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShoppingCenter.ViewModels.Cinemas
{
    [QueryProperty(nameof(Movie), "movie")]
    public partial class DetailPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private Movie movie;
        [RelayCommand]
        private async Task CloseAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
        [RelayCommand]
        private async Task PlayTrailerAsync()
        {
            if (Movie != null && !string.IsNullOrWhiteSpace(Movie.Trailer))
            {
                try
                {
                    await Launcher.Default.OpenAsync(Movie.Trailer);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao abrir o trailer: {ex.Message}");
                }
            }
        }
    }
}