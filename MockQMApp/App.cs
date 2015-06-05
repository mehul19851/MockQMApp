using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using MockQMApp.ContentPages;

namespace MockQMApp
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                XAlign = TextAlignment.Center,
            //                Text = "Welcome to Xamarin Forms!"
            //            }
            //        }
            //    }
            //};
            MainPage = new LoginPage();
            MainPage.Icon = "fortislogo.png";
            //MainPage = new LoginXamlPage();
            //MainPage = new ListViewDemoPage();
            //MainPage = new ImageCellDemoPage();
            //MainPage = new ListViewImageXAMLPage();
            //MainPage = new ListViewWithImagePage();
            //MainPage = new GridDemoPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

       
    }

    public interface IDisplay
    {
        /// <summary>
        /// Gets the screen height in pixels
        /// </summary>
        int Height { get; }

        /// <summary>
        /// Gets the screen width in pixels
        /// </summary>
        int Width { get; }

        /// <summary>
        /// Gets the screens X pixel density per inch
        /// </summary>
        double Xdpi { get; }

        /// <summary>
        /// Gets the screens Y pixel density per inch
        /// </summary>
        double Ydpi { get; }

        Orientation Orientation { get; }
    }

    public enum Orientation
    {
        Portrait = 1,
        Landscape = 2
    }
}
