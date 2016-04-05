using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace F_Gudvis.Timeline
{
    class Timeline : ContentPage
    {
        private User actUser;

        public Timeline(User newUser)
        {
            actUser = newUser;
            Label id = new Label
            {
                Text = "Create an unique username",
                TextColor = Color.Black,
                XAlign = TextAlignment.Center
            };

            Button btnHola = new Button
            {
                Text = "hola mundo ",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("#FF5722")
            };

            BackgroundColor = Color.White;
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                        id, btnHola
                        }
            };
        }
    }
}
