using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using FancyCard.Models;

namespace FancyCard.Views
{
    [DesignTimeVisible(false)]
    public partial class NewCardPage : ContentPage
    {
        public Card Card { get; set; }

        public NewCardPage()
        {
            InitializeComponent();

            Card = new Card
            {
                Title = "Card name",
                Description = "This is a special card."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddCard", Card);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}