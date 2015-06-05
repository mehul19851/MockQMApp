using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace MockQMApp.ContentPages
{
    class ProviderCell : ViewCell
    {

        public ProviderCell()
        {
            var image = new Image
            {
                HorizontalOptions = LayoutOptions.Start,
                Source = "fortislogo.png"
            };

            var nameLayout = CreateNameLayout();
            var viewLayout = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children = { image, nameLayout }
            };
            //View = viewLayout;

        }

        static StackLayout CreateNameLayout()
        {

            var nameLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            nameLabel.SetBinding(Label.TextProperty, "DisplayName");

            var twitterLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            twitterLabel.SetBinding(Label.TextProperty, "Twitter");

            var nameLayout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Vertical,
                Children = { nameLabel, twitterLabel }
            };
            return nameLayout;
        }


    }
}
