using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;


namespace MockQMApp.ContentPages
{
    public class MultiSelectListView : ContentPage
    {
        public MultiSelectListView()
        {
           

            var L_Categories = new List<MultiSelect>();
            int index = 0;
            //
            var Categorie = new MultiSelect() { cIconPfad = "RadioUnchecked.png", cText = "Action & Abenteuer", bSelect = false, iIndex = index, cWebServiceAufruf = "_FZK=ActionAbenteuer" };
            L_Categories.Add(Categorie);
            index = index + 1;
            //
            Categorie = new MultiSelect() { cIconPfad = "RadioUnchecked.png", cText = "Sport", bSelect = false, iIndex = index, cWebServiceAufruf = "_FZK=Sport" };
            L_Categories.Add(Categorie);
            index = index + 1;
            //
            // and so on....
            //
            var ListViewCategories = new ListView() { HeightRequest = 200 };
            ListViewCategories.ItemTemplate = new DataTemplate(typeof(CatergoriesViewCell)); // Update page
            ListViewCategories.ItemsSource = L_Categories;

            //Event handler for the listview

            ListViewCategories.ItemTapped += async (sender, e) =>
            {
                var LVElement = (MultiSelect)e.Item;
                if (LVElement.bSelect) // Item is selected already
                {
                    L_Categories[LVElement.iIndex].bSelect = false;
                    L_Categories[LVElement.iIndex].cIconPfad = "RadioUnchecked.png";
                }
                else
                {
                    L_Categories[LVElement.iIndex].bSelect = true;
                    // For iOS -> black check-icon, for Android and WP -> white check-icon
                    if (Device.OS == TargetPlatform.iOS) { L_Categories[LVElement.iIndex].cIconPfad = "CheckSchwarz.png"; } else { L_Categories[LVElement.iIndex].cIconPfad = "RadioChecked.png"; }
                }
                ListViewCategories.ItemTemplate = new DataTemplate(typeof(CatergoriesViewCell)); // Update Page
            };

            Content = new StackLayout
            {
                BackgroundColor = Color.White,
                Children = {
					new Label { Text = "MultiSelect ListView Demo", FontSize = 16 },
                    ListViewCategories
				}
            };
        }
    }

    class CatergoriesViewCell : ViewCell // Type for Display of ListView items
    {
        public CatergoriesViewCell() // Spezial-definition 
        {
            var DisplayLabel = new Label();
            DisplayLabel.SetBinding(Label.TextProperty, "cText");
            DisplayLabel.VerticalOptions = LayoutOptions.Center;
            DisplayLabel.BindingContextChanged += (sender, e) =>
            {
            };
            var IconDisplay = new Image();
            // Old Version
            //IconDisplay.SetBinding(Image.SourceProperty, "cIconPfad");
            // New Version
            // Note: as IconDisplay.SetBinding(Image.SourceProperty, "cIconPfad"); don't have worked in my Project with WP, I had to implement a special StringToImageConverter for the Binding
            IconDisplay.SetBinding(Image.SourceProperty, new Binding("cIconPfad", BindingMode.OneWay, new StringToImageConverter()));
            //                 
            // pattform-specific settings -> depends on Icon -> not yet finished
            switch (Device.OS)
            {
                case TargetPlatform.WinPhone:
                    IconDisplay.VerticalOptions = LayoutOptions.Center;
                    DisplayLabel.Font = Font.SystemFontOfSize(30);
                    break;
                case TargetPlatform.iOS:
                    IconDisplay.HeightRequest = 15;
                    IconDisplay.VerticalOptions = LayoutOptions.Center;
                    break;
                case TargetPlatform.Android:
                    IconDisplay.HeightRequest = 15;
                    IconDisplay.VerticalOptions = LayoutOptions.Center;
                    break;

            }
            var s = new StackLayout();
            s.Orientation = StackOrientation.Horizontal; // Element horizontal anordnen
            //var s = new TableView();
            s.Children.Add(IconDisplay);
            s.Children.Add(DisplayLabel);
            this.View = s;
        }
    }

    public class StringToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var filename = (string)value;
            return ImageSource.FromFile(filename);
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
