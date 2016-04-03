using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace F_Gudvis.Events
{
    class EventCreation : ContentPage
    {
        private Label lblLOGO, lblStart, lblEnd, lblDescription;
        private Entry txtEventName, txtPhoneNumber, txtEmail, txtAddress;
        private Button btnSave;
        private DatePicker datePicker, datePicker2;
        private Image dateImage, timeImage, dateImage2, timeImage2;
        private TimePicker timePicker, timePicker2;
        private Grid the_grid, basicInfo;
        private DateTime startTime, endTime;
        private Editor txtDescription;
        private ScrollView scrollEditor;
        //private Image eventImage;

        string fontType = Device.OnPlatform(
                    iOS: "MarkerFelt-thin",
                    Android: "sans-serif-light",
                    WinPhone: "Comic Sans Ms"
                );

        public EventCreation()
        {
            #region Button, label and List creation

            lblLOGO = new Label
            {
                Text = "GUDVIS",
                TextColor = Color.FromHex("#FF5252"),
                FontAttributes = FontAttributes.Bold,
                FontFamily = fontType,
                FontSize = 25,
                HorizontalOptions = LayoutOptions.Center,
            };

            lblStart = new Label
            {
                Text = "Start",
                TextColor = Color.White,
                FontFamily = fontType,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalOptions = LayoutOptions.Center
            };

            lblEnd = new Label
            {
                Text = "End",
                TextColor = Color.White,
                FontFamily = fontType,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalOptions = LayoutOptions.Center
            };

            lblDescription = new Label
            {
                TextColor = Color.FromHex("94A3AB"),
                IsEnabled = false,
                FontFamily = fontType,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalOptions = LayoutOptions.Center,
                Text = " More about the event"

            };

            dateImage = new Image
            {
                Source = "calendar.png",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };

            timeImage = new Image
            {
                Source = "clock.png",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };

            dateImage2 = new Image
            {
                Source = "calendar.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };

            timeImage2 = new Image
            {
                Source = "clock.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };

            txtEventName = new Entry
            {
                Placeholder = "Event name",
                FontFamily = fontType,
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)),

            };

            txtPhoneNumber = new Entry
            {
                Placeholder = "Phone number",
                //PlaceholderColor = Color.Gray,
                FontFamily = fontType,
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)),
                Keyboard = Keyboard.Numeric
            };

            txtEmail = new Entry
            {
                Placeholder = "Email",
                FontFamily = fontType,
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)),
                Keyboard = Keyboard.Email
            };

            txtAddress = new Entry
            {
                Placeholder = "Address",
                FontFamily = fontType,
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry))
            };

            txtDescription = new Editor
            {
                FontFamily = fontType,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                Keyboard = Keyboard.Chat,
                HeightRequest = 60,
                MinimumHeightRequest = 60
            };

            scrollEditor = new ScrollView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Orientation = ScrollOrientation.Vertical,

                Content = txtDescription

            };

            btnSave = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.FromHex("#FF5252"),
                Text = "Save",
                TextColor = Color.White,
                FontFamily = fontType,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };

            timePicker = new TimePicker
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            datePicker = new DatePicker
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                MinimumDate = DateTime.Today,
            };

            timePicker2 = new TimePicker
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            datePicker2 = new DatePicker
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                MinimumDate = DateTime.Today,
            };

            btnSave.Clicked += BtnSave_Clicked;
            #endregion

            #region basicInfo Grid
            basicInfo = new Grid
            {
                Padding = new Thickness(1, Device.OnPlatform(0, 0, 0), 0, 0),
                BackgroundColor = Color.FromHex("#455A64"),
                RowDefinitions =
                {
                    new RowDefinition { Height =new GridLength (1, GridUnitType.Star) },
                    new RowDefinition { Height =new GridLength (1, GridUnitType.Star) },
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) }
                }
            };

            basicInfo.Children.Add(txtEventName, 0, 0);
            basicInfo.Children.Add(txtAddress, 1, 0);
            basicInfo.Children.Add(txtPhoneNumber, 0, 1); 
            basicInfo.Children.Add(txtEmail, 1, 1);
            #endregion

            #region the_grid definition
            the_grid = new Grid
            {
                Padding = new Thickness(1, Device.OnPlatform(0, 0, 0), 0, 0),
                BackgroundColor = Color.FromHex("#455A64"),
                RowDefinitions =
                {
                    new RowDefinition { Height =new GridLength (1, GridUnitType.Star) },
                    new RowDefinition { Height =new GridLength (1, GridUnitType.Star) },
                    new RowDefinition { Height =new GridLength (1, GridUnitType.Star) },
                    new RowDefinition { Height =new GridLength (1, GridUnitType.Star) },
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
                },
            };

            the_grid.Children.Add(lblStart, 0, 0);
            the_grid.Children.Add(dateImage, 1, 0);
            the_grid.Children.Add(timeImage, 2, 0);
            the_grid.Children.Add(datePicker, 1, 1);
            the_grid.Children.Add(timePicker, 2, 1);

            the_grid.Children.Add(lblEnd, 0, 2);
            the_grid.Children.Add(dateImage2, 1, 2);
            the_grid.Children.Add(timeImage2, 2, 2);
            the_grid.Children.Add(datePicker2, 1, 3);
            the_grid.Children.Add(timePicker2, 2, 3);


            #endregion

            StackLayout stack_layout = new StackLayout
            {
                BackgroundColor = Color.FromHex("#455A64"),
                Padding = 20,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Fill,
                Children =
                {
                    lblLOGO, basicInfo, lblDescription, txtDescription,
                    the_grid, btnSave
                }
            };

            Content = stack_layout;
        }

        async void BtnSave_Clicked(object sender, EventArgs e)
        {
            string dia, hora, todo;
            dia = datePicker.Date.ToString();
            hora = timePicker.Time.ToString();
            todo = dia.Split(' ')[0] + " " + hora;
            startTime = Convert.ToDateTime(todo);

            dia = datePicker2.Date.ToString();
            hora = timePicker2.Time.ToString();
            todo = dia.Split(' ')[0] + " " + hora;
            endTime = Convert.ToDateTime(todo);

            int res = startTime.CompareTo(endTime);
            if (res != -1) //It means that Start date/time is NOT before End date/time
                await DisplayAlert("Error", "Start date must be earlier than end date", "Ok");
            else
            {
                await DisplayAlert("Congratualations", "Your event has been created", "Ok");
            }

        }
    }
}
