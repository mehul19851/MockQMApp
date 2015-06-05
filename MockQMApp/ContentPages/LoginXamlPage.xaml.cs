using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;


namespace MockQMApp.ContentPages
{
    public partial class LoginXamlPage : ContentPage
    {
        public LoginXamlPage()
        {
            InitializeComponent();

            Username.Focused += (sender, e) =>
            {
                Username.Text = "";
            };

            Password.Focused += (sender, e) =>
            {
                Password.Text = "";
            };

            SigninButton.Clicked += (sender, e) =>
            {
                DisplayAlert("QM App", "Welcome, " + Username.Text, "Close");
                //Navigation.PushAsync(new LoginPage());
                Navigation.PushModalAsync(new LoginPage(), true);
                

            };


        }
    }
}
