using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace F_Gudvis.Profile
{
    public class Profile : ContentPage
    {
        Label lblFollowing, lblNFollowing, lblFollowers, lblNFollowers;
        string fontType = Device.OnPlatform(
                    iOS: "MarkerFelt-thin",
                    Android: "sans-serif-light",
                    WinPhone: "Comic Sans Ms"
                );
        //private User actUser;
        //private FollowConnection fc = new FollowConnection();
        //private List<User> followers, following;

        ///// <summary>
        /////     This method needs to be called 
        ///// </summary>
        ///// <param name="theUser"></param>
        //public void getUserInfo(User theUser)
        //{
        //    actUser = theUser;
        //}

        ///// <summary>
        /////     This function returns the # of followers from actual user
        ///// </summary>
        ///// <returns>
        /////     # of followers
        ///// </returns>
        //private int getFollowers()
        //{
        //    followers = fc.getAllFollowers(actUser.username); //Gets all followers from actual user 
        //    return followers.Count;
        //}

        ///// <summary>
        /////     This function returns the # of followers from actual user
        ///// </summary>
        ///// <returns>
        /////     # of followers
        ///// </returns>
        //private int getFollowing()
        //{
        //    following = fc.getAllFollowing(actUser.username); //Gets all following from actual user 
        //    return following.Count;
        //}

        public Profile()
        {
            //This methods are created for asigning a "onClick" event to each label.
            //with the goal of: everytime a user clicks on his/her followers/following,
            //it will open a new window, showing them.
            //#region TapGesture for labels 
            //TapGestureRecognizer toFollowing = new TapGestureRecognizer
            //{
            //    Command = new Command(() => lblFollowingClicked()),
            //};

            //TapGestureRecognizer toFollowing2 = new TapGestureRecognizer
            //{
            //    Command = new Command(() => lblFollowingClicked()),
            //};

            //TapGestureRecognizer toFollower = new TapGestureRecognizer
            //{
            //    Command = new Command(() => lblFollowersClicked()),
            //};

            //TapGestureRecognizer toFollower2 = new TapGestureRecognizer
            //{
            //    Command = new Command(() => lblFollowersClicked()),
            //};
            //#endregion

            //#region components definition
            //lblFollowing = new Label {
            //    Text = "Following:",
            //    FontSize = 15,
            //    TextColor = Color.Silver,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    VerticalTextAlignment = TextAlignment.Center,
            //    FontFamily = fontType
            //};
            //lblFollowing.GestureRecognizers.Add(toFollowing);

            //lblNFollowing = new Label
            //{
            //    Text = getFollowing().ToString(),
            //    FontSize = 15,
            //    TextColor = Color.Silver,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    VerticalTextAlignment = TextAlignment.Center,
            //    FontFamily = fontType
            //};
            //lblNFollowing.GestureRecognizers.Add(toFollowing2);

            //lblFollowers = new Label
            //{
            //    Text = "Followers",
            //    FontSize = 15,
            //    TextColor = Color.Silver,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    VerticalTextAlignment = TextAlignment.Center,
            //    FontFamily = fontType
            //};
            //lblFollowers.GestureRecognizers.Add(toFollower);

            //lblNFollowers = new Label
            //{
            //    Text = getFollowers().ToString(),
            //    FontSize = 15,
            //    TextColor = Color.Silver,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    VerticalTextAlignment = TextAlignment.Center,
            //    FontFamily = fontType
            //};
            //lblNFollowers.GestureRecognizers.Add(toFollower2);
            //#endregion


            //// DEMO DATA
            //actUser.picture_link = "http://graph.facebook.com/593257725/picture?type=normal&height=130&width=130";
            //actUser.firstname = "Pablo"; actUser.lastname = "Quemé";
            //actUser.username = "avatarbobo";
            //actUser.levelNumber = 5;
            //actUser.location = "Guatemala";
            //actUser.score = 12000;
            //actUser.Level = new Level();

            //var gridFollows = new Grid();
            //gridFollows.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            //gridFollows.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            //gridFollows.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //gridFollows.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //gridFollows.Children.Add(lblFollowers, 0, 0);
            //gridFollows.Children.Add(lblFollowing, 1, 0);
            //gridFollows.Children.Add(lblNFollowers, 0, 1);
            //gridFollows.Children.Add(lblNFollowing, 1, 1);

            //var gridPoints = new Grid();
            //gridPoints.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            //gridPoints.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            //gridPoints.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //gridPoints.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) });
            //gridPoints.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //gridPoints.Children.Add(new Label { BackgroundColor = Color.FromHex("#FF9800"), Text = actUser.score.ToString() + "/15000", FontSize = 15, TextColor = Color.FromHex("#212121"), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, 0);
            //gridPoints.Children.Add(new Label { Text = actUser.levelNumber.ToString(), FontSize = 20, TextColor = Color.Black, FontAttributes = FontAttributes.Bold, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, 0);
            //gridPoints.Children.Add(new Label { Text = (actUser.levelNumber + 1).ToString(), FontSize = 20, TextColor = Color.Black, FontAttributes = FontAttributes.Bold, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 2, 0);

            //var profileStack = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    HorizontalOptions = LayoutOptions.FillAndExpand,
            //    BackgroundColor = Color.FromHex("#00796B"),
            //    Children = {
            //        new Image
            //        {
            //            Source = actUser.picture_link
            //        },
            //        new Label
            //        {
            //            HorizontalTextAlignment = TextAlignment.Center,
            //            Text = actUser.firstname + " " + actUser.lastname,
            //            FontAttributes = FontAttributes.Bold,

            //            TextColor = Color.FromHex("#FFFFFF"),
            //            FontSize = 25
            //        },
            //        new Label
            //        {
            //            HorizontalTextAlignment = TextAlignment.Center,
            //            Text = "@" + actUser.username,
            //            TextColor = Color.FromHex("#FFFFFF"),
            //            FontSize = 18
            //        },
            //        gridFollows,
            //        gridPoints
            //    }
            //};

            //var profileScrollView = new ScrollView
            //{
            //    Content = profileStack
            //};


            //Content = new StackLayout
            //{
            //    BackgroundColor = Color.FromHex("#FFFFFF"),

            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    HorizontalOptions = LayoutOptions.FillAndExpand,
            //    Children = {
            //            profileScrollView
            //        }
            //};
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

        //async void lblFollowingClicked()
        //{
        //    var page = new Following_Follower.ViewFollowing();
        //    await Navigation.PushAsync(page);
        //}

        //async void lblFollowersClicked()
        //{
        //    var page = new Following_Follower.ViewFollowers();
        //    await Navigation.PushAsync(page);
        //}
    }
}
