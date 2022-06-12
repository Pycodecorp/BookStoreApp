using BookStoreApp.Services;
using BookStoreApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookStoreApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<BookDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
