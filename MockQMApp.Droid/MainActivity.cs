using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;
using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace MockQMApp.Droid
{
    [Activity(Label = "MockQMApp", Icon = "@drawable/fortislogo", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    //public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    public class MainActivity : AndroidActivity
    {

        public Orientation Orientation;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());


            //var display = DependencyService.Get<IDisplay>();

            //if (display.Orientation == MockQMApp.Orientation.Landscape)
            //{
            //    App.Current.MainPage.WidthRequest = display.Width * 92 / 100;
                

            //}
            //else if (display.Orientation == MockQMApp.Orientation.Portrait)
            //{
            //    App.Current.MainPage.WidthRequest = display.Width * 85 / 100;
            //}


            //display.Orientation = (Orientation)Resources.Configuration.Orientation;

        }


    }
}

