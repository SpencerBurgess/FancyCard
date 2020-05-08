using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using FancyCard.Models;
using FancyCard.Views;

namespace FancyCard.ViewModels
{
    public class CardsViewModel : BaseViewModel
    {
        public ObservableCollection<Card> Cards { get; set; }
        public Command LoadCardsCommand { get; set; }

        public CardsViewModel()
        {
            Title = "Browse";
            Cards = new ObservableCollection<Card>();
            LoadCardsCommand = new Command(async () => await ExecuteLoadCardsCommand());

            MessagingCenter.Subscribe<NewCardPage, Card>(this, "AddCard", async (obj, card) =>
            {
                var newCard = card as Card;
                Cards.Add(newCard);
                await DataStore.AddCardAsync(newCard);
            });
        }

        async Task ExecuteLoadCardsCommand()
        {
            IsBusy = true;

            try
            {
                Cards.Clear();
                var cards = await DataStore.GetCardsAsync(true);
                foreach (var card in cards)
                {
                    Cards.Add(card);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}