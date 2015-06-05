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
using MockQMApp.Droid;
using MockQMApp;

//[assembly: Xamarin.Forms.Dependency(typeof(CustomDisplay))]

namespace MockQMApp.Droid
{

    //public class CustomDisplay : IDisplay
    //{
    //    public CustomDisplay()
    //    {
    //        Xdpi = Application.Context.Resources.DisplayMetrics.Xdpi;
    //        Ydpi = Application.Context.Resources.DisplayMetrics.Ydpi;
    //    }

    //    public int Height
    //    {
    //        get
    //        {
    //            if (Orientation == Orientation.Portrait)
    //            {
    //                return (int)DpFromPx(Application.Context.Resources.DisplayMetrics.HeightPixels);
    //            }
    //            return (int)DpFromPx(Application.Context.Resources.DisplayMetrics.WidthPixels);
    //        }
    //    }


    //    public int Width
    //    {
    //        get { return (int)DpFromPx(Application.Context.Resources.DisplayMetrics.WidthPixels); }
    //    }

    //    public double Xdpi { get; private set; }

    //    public double Ydpi { get; private set; }

    //    public Orientation Orientation { get; set; }


    //    public override string ToString()
    //    {
    //        return string.Format("[Screen: Height={0}, Width={1}, Xdpi={2:0.0}, Ydpi={3:0.0}]", Height, Width, Xdpi, Ydpi);
    //    }

    //    private static float DpFromPx(int px)
    //    {
    //        return px / Application.Context.Resources.DisplayMetrics.Density;
    //    }
    //}

    public class CustomDisplay : IDisplay
    {
        public int Height { get { return Application.Context.Resources.Configuration.ScreenHeightDp; } }

        public int Width { get { return Application.Context.Resources.Configuration.ScreenWidthDp; } }

        public int HeightPx { get { return Application.Context.Resources.DisplayMetrics.HeightPixels; } }

        public int WidthPx { get { return Application.Context.Resources.DisplayMetrics.WidthPixels; } }

        public float Density { get { return Application.Context.Resources.DisplayMetrics.Density; } }

        public double Xdpi { get { return Application.Context.Resources.DisplayMetrics.Xdpi; } }

        public double Ydpi { get { return Application.Context.Resources.DisplayMetrics.Ydpi; } }

        public Orientation Orientation { get { return (Orientation)(int)Application.Context.Resources.Configuration.Orientation; } }

        public override string ToString()
        {
            return string.Format(@"[
Screen: Height=({0} DP) / ({1} PX), 
Width=({2} DP) / ({3} PX), 
Xdpi={4:0.0}, 
Ydpi={5:0.0}, 
Density={6:0.0}]", Height, HeightPx, Width, WidthPx, Xdpi, Ydpi, Density);
        }
    }

}