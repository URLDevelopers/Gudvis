using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Gudvis_F.Profile
{
    public class Profile : ContentPage
    {
        public Profile()
        {
            User user = new User();
            // DEMO DATA
            user.picture_link = "http://graph.facebook.com/593257725/picture?type=normal&height=130&width=130";
            user.firstname = "Pablo"; user.lastname = "Quemé";
            user.username = "avatarbobo";
            user.LEVELS_number = 5;
            user.location = "Guatemala";
            user.score = 12000;

            var gridFollows = new Grid();
            gridFollows.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            gridFollows.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            gridFollows.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            gridFollows.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            gridFollows.Children.Add(new Label { Text = "Followers:", FontSize = 15, TextColor = Color.Silver, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, 0);
            gridFollows.Children.Add(new Label { Text = "Following:", FontSize = 15, TextColor = Color.Silver, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, 0);
            gridFollows.Children.Add(new Label { Text = "139", FontSize = 15, TextColor = Color.Silver, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, 1);
            gridFollows.Children.Add(new Label { Text = "42", FontSize = 15, TextColor = Color.Silver, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, 1);

            var gridPoints = new Grid();
            gridPoints.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            gridPoints.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            gridPoints.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            gridPoints.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) });
            gridPoints.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            gridPoints.Children.Add(new Label { BackgroundColor = Color.FromHex("#FF9800"), Text = user.score.ToString() + "/15000", FontSize = 15, TextColor = Color.FromHex("#212121"), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, 0);
            gridPoints.Children.Add(new Label { Text = user.LEVELS_number.ToString(), FontSize = 20, TextColor = Color.Black, FontAttributes = FontAttributes.Bold, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, 0);
            gridPoints.Children.Add(new Label { Text = (user.LEVELS_number + 1).ToString(), FontSize = 20, TextColor = Color.Black, FontAttributes = FontAttributes.Bold, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 2, 0);

            var profileStack = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#00796B"),
                Children = {
                    new Image
                    {
                        Source = user.picture_link
                    },
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = user.firstname + " " + user.lastname,
                        FontAttributes = FontAttributes.Bold,

                        TextColor = Color.FromHex("#FFFFFF"),
                        FontSize = 25
                    },
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "@" + user.username,
                        TextColor = Color.FromHex("#FFFFFF"),
                        FontSize = 18
                    },
                    gridFollows,
                    gridPoints
                }
            };

            var profileScrollView = new ScrollView
            {
                Content = profileStack
            };


            Content = new StackLayout
            {
                BackgroundColor = Color.FromHex("#FFFFFF"),

                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = {
                        profileScrollView
                    }
            };
        }
    }
}
