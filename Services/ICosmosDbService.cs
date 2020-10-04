using System.Collections.Generic;
using System.Threading.Tasks;
using Asp.NetCore_CosmosDB.Models;

namespace Asp.NetCore_CosmosDB.Services
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<Item>> GetItemsAsync(string query);
        Task<Item> GetItemAsync(string id);
        Task AddItemAsync(Item item);
        Task UpdateItemAsync(string id, Item item);
        Task DeleteItemAsync(string id);
    }
}
