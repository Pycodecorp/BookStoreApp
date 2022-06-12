using BookStoreApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Services
{
    public class BookDataStore : IDataStore<Item>
    {
        private List<Item> items;
        private Item item;
        static HttpClientHandler insecureHandler = GetInsecureHandler();
        static HttpClient client = new HttpClient(insecureHandler);
        static string url = "http://10.0.2.2:5142/api/Books";

        private static HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                return true;
            };
            return handler;
        }

        public async Task<bool> AddItemAsync(Item item) 
        {
            var converter = JsonConvert.SerializeObject(item);
            var content = new StringContent(converter, Encoding.UTF8, "application/json");
            await client.PostAsync(url, content);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var urlId = url + "/" + item.Id.ToString();
            var converter = JsonConvert.SerializeObject(item);
            var content = new StringContent(converter, Encoding.UTF8, "application/json");
            await client.PutAsync(urlId, content);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id) 
        {
            var strings = url + "/" + id;
            await client.DeleteAsync(strings);
            
            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)  
        {
            var strings = url + "/" + id;
            var book = await client.GetStringAsync(strings);

            item = JsonConvert.DeserializeObject<Item>(book);

            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false) 
        {
            var books = await client.GetStringAsync(url);
            items = JsonConvert.DeserializeObject<List<Item>>(books);

            return await Task.FromResult(items);
        }
    }
}

