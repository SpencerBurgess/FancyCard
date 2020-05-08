using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FancyCard.Models;

namespace FancyCard.Services
{
    public class MockDataStore : IDataStore<Card>
    {
        readonly List<Card> cards;

        public MockDataStore()
        {
            cards = new List<Card>()
            {
                new Card { Id = Guid.NewGuid().ToString(), Title = "First item", Description="This is an item description." },
                new Card { Id = Guid.NewGuid().ToString(), Title = "Second item", Description="This is an item description." },
                new Card { Id = Guid.NewGuid().ToString(), Title = "Third item", Description="This is an item description." },
                new Card { Id = Guid.NewGuid().ToString(), Title = "Fourth item", Description="This is an item description." },
                new Card { Id = Guid.NewGuid().ToString(), Title = "Fifth item", Description="This is an item description." },
                new Card { Id = Guid.NewGuid().ToString(), Title = "Sixth item", Description="This is an item description." }
            };
        }

        public async Task<bool> AddCardAsync(Card card)
        {
            cards.Add(card);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateCardAsync(Card card)
        {
            var oldCard = cards.Where((Card arg) => arg.Id == card.Id).FirstOrDefault();
            cards.Remove(oldCard);
            cards.Add(card);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteCardAsync(string id)
        {
            var oldCard = cards.Where((Card arg) => arg.Id == id).FirstOrDefault();
            cards.Remove(oldCard);

            return await Task.FromResult(true);
        }

        public async Task<Card> GetCardAsync(string id)
        {
            return await Task.FromResult(cards.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Card>> GetCardsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(cards);
        }
    }
}