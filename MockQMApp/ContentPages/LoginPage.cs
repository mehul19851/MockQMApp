using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MockQMApp.ContentPages
{
    public class LoginPage : ContentPage
    {

        Func<View> portraitView;
        Func<View> landscapeView;
        static bool IsPortrait(Page p) { return p.Width < p.Height; }

        public LoginPage()
        {
            //bool IsPortrait = true;
            BackgroundColor = Color.White;

            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.Start,
                RowDefinitions = 
                {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },

                    //new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    //new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) }
                },
                ColumnDefinitions = 
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto }
                    //new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    //new ColumnDefinition { Width = new GridLength(100, GridUnitType.Absolute) }
                }
            };


            #region Commentted code
            //grid.Children.Add(new Label
            //{
            //    Text = "Grid",
            //    Font = Font.BoldSystemFontOfSize(50),
            //    HorizontalOptions = LayoutOptions.Center
            //}, 0, 3, 0, 1);

            //grid.Children.Add(new Label
            //{
            //    Text = "Autosized cell",
            //    TextColor = Color.White,
            //    BackgroundColor = Color.Blue
            //}, 0, 1);

            //grid.Children.Add(new BoxView
            //{
            //    Color = Color.Silver,
            //    HeightRequest = 0
            //}, 1, 1);

            //grid.Children.Add(new BoxView
            //{
            //    Color = Color.Teal
            //}, 0, 2);

            //grid.Children.Add(new Label
            //{
            //    Text = "Leftover space",
            //    TextColor = Color.Purple,
            //    BackgroundColor = Color.Aqua,
            //    XAlign = TextAlignment.Center,
            //    YAlign = TextAlignment.Center,
            //}, 1, 2);

            //grid.Children.Add(new Label
            //{
            //    Text = "Span two rows (or more if you want)",
            //    TextColor = Color.Yellow,
            //    BackgroundColor = Color.Navy,
            //    XAlign = TextAlignment.Center,
            //    YAlign = TextAlignment.Center
            //}, 2, 3, 1, 3);

            //grid.Children.Add(new Label
            //{
            //    Text = "Span 2 columns",
            //    TextColor = Color.Blue,
            //    BackgroundColor = Color.Yellow,
            //    XAlign = TextAlignment.Center,
            //    YAlign = TextAlignment.Center
            //}, 0, 2, 3, 4);

            //grid.Children.Add(new Label
            //{
            //    Text = "Fixed 100x100",
            //    TextColor = Color.Aqua,
            //    BackgroundColor = Color.Red,
            //    XAlign = TextAlignment.Center,
            //    YAlign = TextAlignment.Center
            //}, 2, 3);


            #endregion

            //var grid = new Grid();
            //grid.Children.Add(new Image { Source = "fortislogo.png", WidthRequest = 50, HeightRequest=20 }, 0, 0);
            //grid.Children.Add(new Image { Source = "qmlogo.png", WidthRequest = 75, HeightRequest = 75 }, 1, 0);
             
            
            var display = DependencyService.Get<IDisplay>();


            //if (display.Orientation == MockQMApp.Orientation.Landscape)
            //{
            //    width = display.Width * 60 / 100;
            //    //width = 1200;
            //    //IsPortrait = false;

            //}
            //else if (display.Orientation == MockQMApp.Orientation.Portrait)
            //{
            //    width = display.Width * 30 / 100;
            //    //IsPortrait = true;
            //}


            //Entry Username = new Entry { Text = "Username:", HeightRequest = 42, WidthRequest = width, BackgroundColor = Color.FromHex("#9eccce") };
            //Image fortisLogo = new Image { Source = "fortislogo.png", HeightRequest = 25, HorizontalOptions = LayoutOptions.Start };
            //Image qmLogo = new Image { Source = "qmlogo.png", HorizontalOptions = LayoutOptions.End };

            Image fortisLogo = new Image { Source = "fortislogo.png", HeightRequest = 25, HorizontalOptions = LayoutOptions.Start, VerticalOptions = LayoutOptions.Start };
            Image qmLogo = new Image { Source = "qmlogo.png", HeightRequest = 18, HorizontalOptions = LayoutOptions.End, VerticalOptions = LayoutOptions.End };
            Entry Username = new Entry { Text = "Username:", HeightRequest = 42, BackgroundColor = Color.FromHex("#9eccce") };
            Entry Password = new Entry { Text = "Password:", HeightRequest = 42, BackgroundColor = Color.FromHex("#9eccce") };
            Button SignInButton = new Button { Text = "SIGN IN:", HeightRequest = 42, BackgroundColor = Color.FromHex("#385b63") };
            Label Copyright = new Label { Text = " © Copyright 2015 VitalHealth Software. All Rights Reserved.", FontSize = 11, HorizontalOptions = LayoutOptions.Center, TextColor = Color.FromHex("#BDBDBD") };

            grid.Children.Add(fortisLogo, 0, 0);
            grid.Children.Add(qmLogo, 0, 0);
            grid.Children.Add(Username, 0, 1);
            Grid.SetColumnSpan(Username, 2);
            grid.Children.Add(Password, 0, 2);
            Grid.SetColumnSpan(Password, 2);
            grid.Children.Add(SignInButton, 0, 3);
            Grid.SetColumnSpan(SignInButton, 2);
            grid.Children.Add(Copyright, 0, 4);
            //Grid.SetColumnSpan(Copyright, 2);
            grid.HorizontalOptions = LayoutOptions.Center;

            Username.Focused += (sender, e) =>
            {
                Username.Text = "";
            };

            Password.Focused += (sender, e) =>
            {
                Password.Text = "";
            };

            SignInButton.Clicked += (sender, e) =>
            {
                DisplayAlert("QM App", "Welcome, " + Username.Text , "Close");
                //Navigation.PushAsync(new LoginPage());
                Navigation.PushModalAsync(new RootPage(), true);
            };


            portraitView = () => new StackLayout
                  {
                      Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0),
                      VerticalOptions = LayoutOptions.Center,
                      HorizontalOptions = LayoutOptions.Center,
                      WidthRequest = display.Width * 85 / 100,
                      Spacing = 10,
                      Children = {
                            grid
                        }
                    
                  };

            landscapeView = () => new StackLayout
            {
                Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = display.Width * 60 / 100,
                Spacing = 10,
                Children = {
                    grid
                }
            };

            SizeChanged += (sender, e) => Content = IsPortrait(this) ? portraitView() : landscapeView();
        }

        

    }
}

