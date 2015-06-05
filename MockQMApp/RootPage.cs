using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MockQMApp.ContentPages;

namespace MockQMApp
{
    class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            var menuPage = new MenuPage();

            menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as MenuItem);
            BackgroundColor = Color.White;
            Master = menuPage;
            Master.BackgroundColor = Color.White;
            Detail = new NavigationPage(new GridDemoPage());
        }

        void NavigateTo(MenuItem menu)
        {
            Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);

            Detail = new NavigationPage(displayPage);

            IsPresented = false;
        }
    }
}
