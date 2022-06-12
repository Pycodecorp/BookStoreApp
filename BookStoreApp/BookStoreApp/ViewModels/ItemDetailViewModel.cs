using BookStoreApp.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BookStoreApp.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string name;
        private decimal price;
        private string category;
        private string author;
        public string Id { get; set; }

        public Command UpdateCommand { get; }
        public Command DeleteCommand { get; }

        public ItemDetailViewModel()
        {
            UpdateCommand = new Command(Update);
            DeleteCommand = new Command(Delete);
        }

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
        public decimal Price
        {
            get => price;
            set => SetProperty(ref price, value);
        } 
        public string Category
        {
            get => category;
            set => SetProperty(ref category, value);
        } 
        public string Author
        {
            get => author;
            set => SetProperty(ref author, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Name = item.Name;
                Price = item.Price;
                Category = item.Category;
                Author = item.Author;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

        private async void Delete()
        {
            await DataStore.DeleteItemAsync(ItemId);
            await Shell.Current.GoToAsync("..");
        }

        private async void Update()
        {
            Item item = new Item { Id = itemId, Name = name, Price = price, Category = category, Author = author};
            await DataStore.UpdateItemAsync(item);
            await Shell.Current.GoToAsync("..");
        }
    }
}
