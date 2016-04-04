using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace F_Gudvis
{
    class Home : ContentPage
    {
        string fontType = Device.OnPlatform(
                    iOS: "MarkerFelt-thin",
                    Android: "sans-serif-light",
                    WinPhone: "Comic Sans Ms"
                );
        Button login, Partner;
        Image logo;

       async void Partner_Clicked(object sender, EventArgs e)
        {
            var page = new Partner.Partner();
            App.Current.MainPage = page;
        }

        async void Login_Clicked(object sender, EventArgs e)
        {
            var page = new Navigation_Drawer.RootPage();
            App.Current.MainPage = page;
            //var page = new Log_In.Auth();
            //App.Current.MainPage = page;
        }

        public Home()
        {
            login = new Button
            {
                WidthRequest = 200,
                FontFamily = fontType,
                Text = "Log in with Facebook",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("#536DFE"),
                HorizontalOptions = LayoutOptions.Center

            };

            login.Clicked += Login_Clicked;

            Partner = new Button
            {
                WidthRequest = 200,
                FontFamily = fontType,
                Text = "Sign up as a Partner",
                BackgroundColor = Color.FromHex("#E64A19"),
                TextColor = Color.FromHex("#FFFFFF"),
                HorizontalOptions = LayoutOptions.Center

            };

            Partner.Clicked += Partner_Clicked;

            logo = new Image
            {
                Source = ImageSource.FromFile("gudvis.jpg"),
                HeightRequest = 300,
                WidthRequest = 300

            };

            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.Children.Add(Partner, 0, 0);
            grid.Children.Add(login, 0, 1);


            BackgroundColor = Color.FromHex("#f5f5f5");
            Content = new StackLayout
            {
                Spacing = 10,
                Padding = 10,
                Children =
                {
                    logo, grid
                }

            };
        }

        
    }
}
