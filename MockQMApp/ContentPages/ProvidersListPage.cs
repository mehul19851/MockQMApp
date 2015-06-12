using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MockQMApp.ContentPages
{
    public class ProvidersListPage : ContentPage
    {
        ListView listView;

        public ProvidersListPage()
        {
            Title = "Providers List";
            listView = new ListView();
            listView.ItemTemplate = new DataTemplate
                    (typeof(ProviderCell));
        }
    }
}
