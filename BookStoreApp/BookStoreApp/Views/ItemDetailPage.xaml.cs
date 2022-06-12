using BookStoreApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BookStoreApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}