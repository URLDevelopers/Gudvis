using System;
using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace Cards
{
	public class CardDetailsView : ContentView
	{
        string fontType = Device.OnPlatform(
                    iOS: "MarkerFelt-thin",
                    Android: "sans-serif-light",
                    WinPhone: "Comic Sans Ms"
                );

        public CardDetailsView (Card card)
		{
			BackgroundColor = Color.White;

            var ProfilePicture = new CircleImage()
            {
                BorderColor = Color.Gray,
                BorderThickness = 2,
                HeightRequest = 50,
                WidthRequest = 50,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Source = card.ProfilePicture
            };
            var name = new Label()
            {
                FontFamily = fontType,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                Text = card.CompleteName,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Start,
            };
            var username = new Label()
            {
                FontFamily = fontType,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                TextColor = Color.Gray,
                Text = card.Username,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.End,
            };
            var level = new Label()
            {
                FontFamily = fontType,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                TextColor = Color.Gray,
                Text = card.Level,
                HorizontalTextAlignment = TextAlignment.End,
                VerticalTextAlignment = TextAlignment.End,
            };

            var grid = new Grid() {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5),
                RowDefinitions =
                {
                    new RowDefinition {  Height = new GridLength(1, GridUnitType.Star) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width =new GridLength(1, GridUnitType.Star)}

                }
			};

            grid.Children.Add(ProfilePicture); Grid.SetColumn(ProfilePicture, 0); Grid.SetRow(ProfilePicture, 0);
            grid.Children.Add(name); Grid.SetColumn(name, 1); Grid.SetRow(name, 0);
            grid.Children.Add(username); Grid.SetColumn(username, 1); Grid.SetRow(username, 0);
            grid.Children.Add(level); Grid.SetColumn(level, 2); Grid.SetRow(level, 0);

            Content = grid;
		}
	}
}