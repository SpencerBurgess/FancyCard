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
        public Card card { get; set; }

        public NewCardPage()
        {
            InitializeComponent();

            card = new Card
            {
                Title = "Card name",
                Description = "This is an item description."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddCard", card);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}