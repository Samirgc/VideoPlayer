using System;
using MyVideoPlayer.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyVideoPlayer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MyVideoPlayerPage());
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
