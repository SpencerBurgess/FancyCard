using System;

using FancyCard.Models;

namespace FancyCard.ViewModels
{
    public class CardDetailViewModel : BaseViewModel
    {
        public Card Card { get; set; }
        public CardDetailViewModel(Card card = null)
        {
            Title = card?.Title;
            Card = card;
        }
    }
}
