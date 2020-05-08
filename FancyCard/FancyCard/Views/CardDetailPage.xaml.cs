using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FancyCard.Models;
using FancyCard.ViewModels;

namespace FancyCard.Views
{
    [DesignTimeVisible(false)]
    public partial class CardDetailPage : ContentPage
    {
        CardDetailViewModel viewModel;

        public CardDetailPage(CardDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public CardDetailPage()
        {
            InitializeComponent();

            var card = new Card
            {
                Title = "Card 1",
                Description = "This is an item description."
            };

            viewModel = new CardDetailViewModel(card);
            BindingContext = viewModel;
        }
    }
}