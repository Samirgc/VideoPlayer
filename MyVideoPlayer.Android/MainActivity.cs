using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Android.OS;

using Android.Content.Res;
using Plugin.DeviceOrientation;
using Plugin.CurrentActivity;

namespace MyVideoPlayer.Droid
{
    [Activity(Label = "MyVideoPlayer", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            
            base.OnCreate(savedInstanceState);
            CrossCurrentActivity.Current.Activity = this;
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
          

            LoadApplication(new App());
        }
        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);

            DeviceOrientationImplementation.NotifyOrientationChange(newConfig.Orientation);
        }
    }
}