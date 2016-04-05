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
        ListView ListTimeLine;
        string fontType = Device.OnPlatform(
                    iOS: "MarkerFelt-thin",
                    Android: "sans-serif-light",
                    WinPhone: "Comic Sans Ms"
                );
        private User actUser = new User();
        private FollowConnection fc = new FollowConnection();
        private List<User> followers, following;

        #region class Methods
        /// <summary>
        ///     This function returns the # of followers from actual user
        /// </summary>
        /// <returns>
        ///     # of followers
        /// </returns>
        private int getFollowers()
        {
            return 1000;
            if (actUser.fbID != null)
            {
                followers = fc.getAllFollowers(actUser.username); //Gets all followers from actual user 
                return followers.Count;
            }
            else
                return 0;
        }

        /// <summary>
        ///     This function returns the # of followers from actual user
        /// </summary>
        /// <returns>
        ///     # of followers
        /// </returns>
        private int getFollowing()
        {
            return 200;
            if (actUser.fbID != null)
            {
                following = fc.getAllFollowing(actUser.username); //Gets all following from actual user 
                return following.Count;
            }
            else
                return 0;
        }
        #endregion+

        public Profile(User newUser)
        {
            actUser = newUser;
            //This methods are created for asigning a "onClick" event to each label.
            //with the goal of: everytime a user clicks on his/her followers/following,
            //it will open a new window, showing them.
            #region TapGesture for labels 
            TapGestureRecognizer toFollowing = new TapGestureRecognizer
            {
                Command = new Command(() => lblFollowingClicked()),
            };

            TapGestureRecognizer toFollowing2 = new TapGestureRecognizer
            {
                Command = new Command(() => lblFollowingClicked()),
            };

            TapGestureRecognizer toFollower = new TapGestureRecognizer
            {
                Command = new Command(() => lblFollowersClicked()),
            };

            TapGestureRecognizer toFollower2 = new TapGestureRecognizer
            {
                Command = new Command(() => lblFollowersClicked()),
            };
            #endregion

            #region components definition
            lblFollowing = new Label
            {
                Text = "Following:",
                FontSize = 15,
                TextColor = Color.Silver,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };
            lblFollowing.GestureRecognizers.Add(toFollowing);

            lblNFollowing = new Label
            {
                FontSize = 15,
                TextColor = Color.Silver,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };
            lblNFollowing.GestureRecognizers.Add(toFollowing2);

            lblFollowers = new Label
            {
                Text = "Followers",
                FontSize = 15,
                TextColor = Color.Silver,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };
            lblFollowers.GestureRecognizers.Add(toFollower);

            lblNFollowers = new Label
            {
                FontSize = 15,
                TextColor = Color.Silver,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };
            lblNFollowers.GestureRecognizers.Add(toFollower2);
            #endregion


            // DEMO DATA
            //actUser.picture_link = "http://graph.facebook.com/593257725/picture?type=normal&height=130&width=130";
            //actUser.firstname = "Pablo"; actUser.lastname = "Quemé";
            //actUser.username = "avatarbobo";
            actUser.levelNumber = 5;
            actUser.location = "Guatemala";
            actUser.score = 12000;
            actUser.Level = new Level();
            lblNFollowing.Text = getFollowing().ToString();
            lblNFollowers.Text = getFollowers().ToString();

            var gridFollows = new Grid();
            gridFollows.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            gridFollows.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            gridFollows.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            gridFollows.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            gridFollows.Children.Add(lblFollowers, 0, 0);
            gridFollows.Children.Add(lblFollowing, 1, 0);
            gridFollows.Children.Add(lblNFollowers, 0, 1);
            gridFollows.Children.Add(lblNFollowing, 1, 1);

            var gridPoints = new Grid();
            gridPoints.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            gridPoints.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            gridPoints.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            gridPoints.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) });
            gridPoints.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            gridPoints.Children.Add(new Label { BackgroundColor = Color.FromHex("#FF9800"), Text = actUser.score.ToString() + "/15000", FontSize = 15, TextColor = Color.FromHex("#212121"), HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 1, 0);
            gridPoints.Children.Add(new Label { Text = actUser.levelNumber.ToString(), FontSize = 20, TextColor = Color.Black, FontAttributes = FontAttributes.Bold, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 0, 0);
            gridPoints.Children.Add(new Label { Text = (actUser.levelNumber + 1).ToString(), FontSize = 20, TextColor = Color.Black, FontAttributes = FontAttributes.Bold, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, 2, 0);

            var profileStack = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#00796B"),
                Children = {
                    new Image
                    {
                        Source = actUser.picture_link
                    },
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = actUser.firstname + " " + actUser.lastname,
                        FontAttributes = FontAttributes.Bold,

                        TextColor = Color.FromHex("#FFFFFF"),
                        FontSize = 25
                    },
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "@" + actUser.username,
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
            #region TimeLinePerEvents
            //Esta lista solamente es como una demo
            List<Event> Asistidos = new List<Event>() {
                new Event() {name = "Plantemos", startDateTime =  DateTime.Today.Date, endDateTime = DateTime.Today.Date},
            };
            //Esta lista solamente es como una demo
            List<Event> Asistira = new List<Event>() {
                new Event() {name = "Plantemos", startDateTime =  DateTime.Today.Date, endDateTime = DateTime.Today.Date},
            };

            List<EventUsing> Assis = GetInfoTimeLine(Asistidos).ToList();
            List<EventUsing> Attend = GetInfoTimeLine(Asistira).ToList();
            EventContent Assisted = new EventContent("Assisted");
            foreach (EventUsing data in Assis)
            {
                Assisted.Add(data);
            }
            EventContent Attended = new EventContent("Attended");
            foreach (EventUsing data in Attend)
            {
                Attended.Add(data);
            }

            List<EventContent> EventDesc = new List<EventContent>();
            EventDesc.Add(Assisted);
            EventDesc.Add(Attended);

            var dataTemplate = new DataTemplate(typeof(CustomCell));

            ListTimeLine = new ListView()
            {
                IsGroupingEnabled = true,
                GroupDisplayBinding = new Binding("Name"),
                GroupShortNameBinding = new Binding("Name"),
                ItemsSource = EventDesc,
                ItemTemplate = dataTemplate,
                GroupHeaderTemplate = new DataTemplate(typeof(EventTemplate)),
                HasUnevenRows = true
            };
            #endregion

            Content = new StackLayout
            {
                BackgroundColor = Color.FromHex("#FFFFFF"),

                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = {
                        profileScrollView,
                        ListTimeLine
                    }
            };
            ListTimeLine.ItemSelected += OnItemSelected;
        }

        #region Components Methods
        async void lblFollowingClicked()
        {
            var page = new Following_Follower.ViewFollowing();
            await Navigation.PushAsync(page);
        }

        async void lblFollowersClicked()
        {
            var page = new Following_Follower.ViewFollowers();
            await Navigation.PushAsync(page);
        }
        #endregion

        #region Class Profile TimeLine
        class EventTemplate : ViewCell
        {
            public EventTemplate()
            {
                var text = new Label();
                text.SetBinding(Label.TextProperty, "Name");
                text.HorizontalTextAlignment = TextAlignment.Center;
                text.TextColor = Color.Aqua;

                var view = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Children = {
                        text
                    }
                };

                View = view;
            }
        }

        class EventContent : System.Collections.ObjectModel.ObservableCollection<EventUsing>
        {
            public EventContent(string name)
            {
                Name = name;
            }

            public string Name { get; set; }
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            // Deselect row
            ListTimeLine.SelectedItem = null;

            var page = new Events.ViewEvent();
            await Navigation.PushAsync(page);
        }

        class CustomCell : ViewCell
        {
            public CustomCell()
            {
                var nameEvent = new Label();
                nameEvent.SetBinding(Label.TextProperty, "name");
                nameEvent.TextColor = Color.Blue;

                var startDate = new Label()
                {
                    Text = "Start:",
                    FontAttributes = FontAttributes.Bold
                };

                var start = new Label();
                start.SetBinding(Label.TextProperty, "startDateTime");

                var endDate = new Label()
                {
                    Text = "End:",
                    FontAttributes = FontAttributes.Bold
                };

                var end = new Label();
                end.SetBinding(Label.TextProperty, "endDateTime");

                var view = new StackLayout()
                {
                    Orientation = StackOrientation.Vertical,
                    Spacing = 0,
                    Padding = 10,
                    Children =
                    {
                        nameEvent,
                        new StackLayout {
                            Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                     startDate,
                                     start,
                                     endDate,
                                     end
                                }
                        }

                    }
                };
                View = view;
            }
        }

         List<EventUsing> GetInfoTimeLine(List<Event> ResumeData)
        {
            List<EventUsing> data = new List<EventUsing>();
            EventUsing Ev = new EventUsing();
            foreach (Event dat in ResumeData)
            {
                Ev.name = dat.name;
                Ev.startDateTime = dat.startDateTime.Date.ToString("dd/MM/yyyy");
                Ev.endDateTime = dat.endDateTime.Date.ToString("dd/MM/yyyy");
                data.Add(Ev);
            }
            return data;
        }
        public class EventUsing
        {
            public string name { get; set; }
            public string startDateTime { get; set; }
            public string endDateTime { get; set; }
        }
        #endregion
    }
}
