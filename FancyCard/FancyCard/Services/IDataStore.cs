using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FancyCard.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddCardAsync(T Card);
        Task<bool> UpdateCardAsync(T Card);
        Task<bool> DeleteCardAsync(string id);
        Task<T> GetCardAsync(string id);
        Task<IEnumerable<T>> GetCardsAsync(bool forceRefresh = false);
    }
}
