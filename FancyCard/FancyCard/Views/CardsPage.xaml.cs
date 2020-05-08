using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using FancyCard.Models;
using FancyCard.Views;
using FancyCard.ViewModels;

namespace FancyCard.Views
{
    [DesignTimeVisible(false)]
    public partial class CardsPage : ContentPage
    {
        CardsViewModel viewModel;

        public CardsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new CardsViewModel();
        }

        async void OnCardSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            var card = (Card)layout.BindingContext;
            await Navigation.PushAsync(new CardDetailPage(new CardDetailViewModel(card)));
        }

        async void AddCard_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewCardPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Cards.Count == 0)
                viewModel.IsBusy = true;
        }
    }
}