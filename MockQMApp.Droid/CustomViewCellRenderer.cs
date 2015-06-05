using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using MockQMApp.ContentPages;
using MockQMApp.ContentPages.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using MockQMApp.Droid;


[assembly: ExportRenderer (typeof (ProvidersCell), typeof (CustomViewCellRenderer))]

namespace MockQMApp.Droid
{
    class CustomViewCellRenderer : CellRenderer
    {

        protected override void OnCellPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnCellPropertyChanged(sender, e);

            if (Cell != null) { }
                            
                //Cell.SetBackgroundColor (global::Android.Graphics.Color.DarkGray);

            
        }
    }
}