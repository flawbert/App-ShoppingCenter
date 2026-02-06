using AppShoppingCenter.Models;
using AppShoppingCenter.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppShoppingCenter.ViewModels.Stores
{
    public partial class ListPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string textSearch;

        private List<Establishment> establishmentsFull;

        [ObservableProperty]
        private List<Establishment> establishmentsFiltered;

        public ListPageViewModel()
        {
            var service = App.Current.Handler.MauiContext.Services.GetService<StoreService>();
            establishmentsFull = service.GetStores();
            establishmentsFiltered = establishmentsFull.ToList();
        }
        partial void OnTextSearchChanged(string value)
        {
            var search = value ?? "";

            EstablishmentsFiltered = establishmentsFull
                .Where(a => a.Name.ToLower().Contains(search.ToLower()))
                .ToList();
        }

[RelayCommand]
        private async void OnTapEstablishmentGoToDetailPage(Establishment establishment)
        {
            var navigationParameter = new Dictionary<string, object>()
        {
            { "establishment", establishment }
        };
            await Shell.Current.GoToAsync("detail", navigationParameter);
        }
    }
}