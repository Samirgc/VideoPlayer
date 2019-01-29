using System;
using System.Collections.Generic;
using MyVideoPlayer.Models;
using MyVideoPlayer.ViewModels;
using Xamarin.Forms;

namespace MyVideoPlayer.Views
{
    public partial class MyVideoPlayerPage : ContentPage
    {
        public MyVideoPlayerPage()
        {
            InitializeComponent();
            BindingContext = new MyVideoViewModel();
        }


        async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var mydetails = e.Item as MyVideoModel;

            // App.Current.MainPage = new MyVideoDetailPage(mydetails.VideoURl);

            await Navigation.PushAsync(new MyVideoDetailPage(mydetails.VideoURl, mydetails.Title));
        }
    }
}
