using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace F_Gudvis.Settings
{
    class Settings : ContentPage
    {
        private User actUser;

        public Settings(User newUser)
        {
            actUser = newUser;

            Label id = new Label
            {
                Text = "This is your settings page",
                TextColor = Color.Black,
                XAlign = TextAlignment.Center
            };

            BackgroundColor = Color.White;
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                        id
                        }
            };
        }
    }
}
