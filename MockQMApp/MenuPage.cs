using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MockQMApp.ContentPages;


namespace MockQMApp
{
    class MenuPage : ContentPage
    {
        public ListView Menu { get; set; }

        public MenuPage()
        {
            Icon = "menu.png";
            Title = "menu"; // The Title property must be set.
            BackgroundColor = Color.White;

            Menu = new MenuListView();

            var menuLabel = new ContentView
            {
                Padding = new Thickness(10, 36, 0, 5),
                Content = new Label
                {
                    TextColor = Color.FromHex("AAAAAA"),
                    Text = "MENU",
                }
            };

            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(10, 10, 5, 5),
            };
            //layout.Children.Add(menuLabel);
            layout.Children.Add(Menu);

            Content = layout;
        }
    }

    public class MenuItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }

    public class MenuListView : ListView
    {
        public MenuListView()
        {
            List<MenuItem> data = new MenuListData();

            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;

            var cell = new DataTemplate(typeof(ImageCell));
            cell.SetBinding(TextCell.TextProperty, "Title");
            cell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");

            ItemTemplate = cell;
        }
    }

    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Title = "Home",
                IconSource = "heart.png",
                TargetType = typeof(GridDemoPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Latest Recommendations - ImageCell",
                IconSource = "diabetes.png",
                TargetType = typeof(ImageCellDemoPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Change Language",
                IconSource = "icon.png",
                TargetType = typeof(ListViewDemoPage)
            });

            this.Add(new MenuItem()
            {
                Title = "MultiSelect Listview",
                IconSource = "icon.png",
                TargetType = typeof(MultiSelectListView)
            });

            this.Add(new MenuItem()
            {
                Title = "Logout",
                IconSource = "password.png",
                TargetType = typeof(LoginPage)
            });
        }
    }
}
