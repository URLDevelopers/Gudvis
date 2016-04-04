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

        public void getUser(User newUser)
        {
            actUser = newUser;
        }
        public Settings()
        {

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
