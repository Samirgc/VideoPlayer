using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyVideoPlayer.Models;
using MyVideoPlayer.ViewModels;
using Plugin.DeviceOrientation;
using Plugin.DeviceOrientation.Abstractions;
using Rox;
using Xamarin.Forms;

namespace MyVideoPlayer.Views
{
    public partial class MyVideoDetailPage : ContentPage
    {

     public static string MyTitle { get; set; }

    
        public MyVideoDetailPage(String MyDetailVideoURL, string VideoTitle)
        {

            


            InitializeComponent();

            BindingContext = new MyVideoViewModel();

            Device.BeginInvokeOnMainThread(() => {
                Title = VideoTitle;
                myroxy.Source = MyDetailVideoURL;




              

            });



            CrossDeviceOrientation.Current.OrientationChanged += CurrentOnOrientationChanged;





        }

      


        private void CurrentOnOrientationChanged(object sender, OrientationChangedEventArgs e)
        {
            if (e.Orientation == DeviceOrientations.Portrait)
            {
                Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, true);
                MyRow.Height = new GridLength(1, GridUnitType.Star);
                MyStack.IsVisible = true;
                Playlist.IsVisible = true;

            }
            else if (e.Orientation == DeviceOrientations.Landscape)
            {
                Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);


                MyRow.Height = new GridLength(0.0, GridUnitType.Absolute);
                Playlist.IsVisible = true;
                MyStack.IsVisible = false;
            }
            else if (e.Orientation == DeviceOrientations.LandscapeFlipped)
            {
                Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
               MyRow.Height =  new GridLength(00, GridUnitType.Absolute); 
                Playlist.IsVisible = false;
                MyStack.IsVisible = false;
            }
            else
            {
                Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, true);
                MyRow.Height = new GridLength(1, GridUnitType.Star);
                MyStack.IsVisible = true;
                
                Playlist.IsVisible = true;
            }



        }




    }
}





