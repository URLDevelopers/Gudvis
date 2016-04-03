using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Gudvis_final.Log_In
{
    public class Auth : ContentPage
    {

        string fontType = Device.OnPlatform(
                    iOS: "MarkerFelt-thin",
                    Android: "sans-serif-light",
                    WinPhone: "Comic Sans Ms"
                );
        public Auth()
        {
            ActivityIndicator loading = new ActivityIndicator()
            {
                Color = Color.FromHex("#FF5722"),
                IsRunning = true,
            };
            
            Label elLabel = new Label()
            {
                Text = "Loading...",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontFamily = fontType,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center,
            };

            Grid the_grid = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.White,
                RowDefinitions =
                {
                    new RowDefinition { Height =new GridLength (1, GridUnitType.Star) },
                    new RowDefinition { Height =new GridLength (1, GridUnitType.Star) },
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
                },

            };

            the_grid.Children.Add(loading, 0, 0);
            the_grid.Children.Add(elLabel, 0, 1);
            Content = new StackLayout
            {
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    the_grid
                }
            };
        }
    }
}
