using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MockQMApp.ContentPages
{
    public class ImageCellDemoPage : ContentPage
    {
        //public ImageCellDemoPage()
        //{
        //    Content = new StackLayout
        //    {
        //        Children = {
        //            new Label { Text = "Hello ContentPage" }
        //        }
        //    };
        //}

        public ImageCellDemoPage()
        {
            

            Label header = new Label
            {
                Text = "Choose a Provider",
                Font = Font.BoldSystemFontOfSize(30),
                HorizontalOptions = LayoutOptions.Center
            };
            Title = "ImageCell demo";
            BackgroundColor = Color.White;
            TableView tableView = new TableView
            {
                Intent = TableIntent.Form,
                HorizontalOptions = LayoutOptions.Center,
                Root = new TableRoot
                {
                    new TableSection
                    {
                        //new ImageCell
                        //{
                        //    // Some differences with loading images in initial release.
                        //    //ImageSource =
                        //        //Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
                        //                          //ImageSource.FromFile("ide_xamarin_studio.png"),
                        //                          //ImageSource.FromFile("Images/ide-xamarin-studio.png")),
                        //    ImageSource = ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png"))
                        //    //,
                        //    //Text = "This is an ImageCell",
                        //    //Detail = "This is some detail text",
                        //},
                         new ImageCell
                        {
                            ImageSource = ImageSource.FromFile("fortislogo.png"),
                            Text = "Forts"
                        },
                        new ImageCell
                        {
                            ImageSource = ImageSource.FromFile("meradoctorlogo.png"),
                            Text = "Mera Doctor"
                        },
                        new ImageCell
                        {
                            ImageSource = ImageSource.FromUri(new Uri("https://cdn.rawgit.com/valdetero/Chocolatey-Packages/dc4c7d41433ce2be79dd235de9e14f3f7633c10b/Xamarin/xamarin.png")),
                            Text = "Xamarin"
                        }
                    }
                    
                }
                
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    tableView
                },
                //BackgroundColor = Color.White                
            };
        }
    }
}
