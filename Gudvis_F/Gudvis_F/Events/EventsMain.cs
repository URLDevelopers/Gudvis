using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Gudvis_F.Events
{
    class EventsMain : ContentPage 
    {

        Button btnView, btnCreate;

        string fontType = Device.OnPlatform(
                    iOS: "MarkerFelt-thin",
                    Android: "sans-serif-light",
                    WinPhone: "Comic Sans Ms"
                );

        

        public EventsMain()
        {
            btnView = new Button
            {
                FontFamily = fontType,
                Text = "View Event",
                BackgroundColor = Color.FromHex("#FF5252")
            };

            btnCreate = new Button
            {
                FontFamily = fontType,
                Text = "Create Event",
                BackgroundColor = Color.FromHex("#FFC107")
            };

            btnCreate.Clicked += BtnCreate_Clicked;
            btnView.Clicked += BtnView_Clicked;

            Grid the_grid = new Grid
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,

                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength (1, GridUnitType.Star) }
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) }
                }
            };

            the_grid.Children.Add(btnView, 0, 0);
            the_grid.Children.Add(btnCreate, 0, 1);
            Content = the_grid;
        }

        async void BtnCreate_Clicked(object sender, EventArgs e)
        {
            var page = new Events.EventCreation();
            await Navigation.PushAsync(page);
        }

        async void BtnView_Clicked(object sender, EventArgs e)
        {
            var page = new Events.ViewEvent();
            await Navigation.PushAsync(page);
        }
    }
}
