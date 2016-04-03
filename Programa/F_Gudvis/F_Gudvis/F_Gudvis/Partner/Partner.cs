using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace F_Gudvis.Partner
{
    class Partner : ContentPage
    {
        private Label lblLOGO;
        private Entry txtCompany, txtPassword, txtPhoneNumber, txtEmail, txtAddress;
        private Button btnSave;

        string fontType = Device.OnPlatform(
                    iOS: "MarkerFelt-thin",
                    Android: "sans-serif-light",
                    WinPhone: "Comic Sans Ms"
                );

        public Partner()
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

            txtCompany = new Entry
            {
                Placeholder = "Company name",
                FontFamily = fontType,
                TextColor = Color.Black,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry))
            };

            txtPassword = new Entry
            {
                Placeholder = "Password",
                FontFamily = fontType,
                TextColor = Color.Black,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)),
                IsPassword = true
            };

            txtPhoneNumber = new Entry
            {
                Placeholder = "Phone number",
                FontFamily = fontType,
                TextColor = Color.Black,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)),
                Keyboard = Keyboard.Numeric
            };

            txtEmail = new Entry
            {
                Placeholder = "Email",
                FontFamily = fontType,
                TextColor = Color.Black,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry)),
                Keyboard = Keyboard.Email
            };

            txtAddress = new Entry
            {
                Placeholder = "Address",
                FontFamily = fontType,
                TextColor = Color.Black,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Entry))
            };

            btnSave = new Button()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.FromHex("#FF5252"),
                Text = "Save",
                TextColor = Color.White,
                FontFamily = fontType,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };

            btnSave.Clicked += BtnSave_Clicked;
            #endregion

            #region Grid definition
            Grid the_grid = new Grid
            {
                Padding = new Thickness(2, Device.OnPlatform(20, 0, 0), 0, 0),
                BackgroundColor = Color.FromHex("#607D8B"),
                RowDefinitions =
                {
                    new RowDefinition { Height =new GridLength (1, GridUnitType.Star) },
                    new RowDefinition { Height =new GridLength (1, GridUnitType.Star) },
                    new RowDefinition { Height =new GridLength (1, GridUnitType.Star) },
                    new RowDefinition { Height =new GridLength (1, GridUnitType.Star) },
                    new RowDefinition { Height =new GridLength (1, GridUnitType.Star) },
                    new RowDefinition { Height =new GridLength (1, GridUnitType.Star) },
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) }
                },
            };

            the_grid.Children.Add(lblLOGO, 0, 0);
            the_grid.Children.Add(txtAddress, 0, 2);
            the_grid.Children.Add(txtCompany, 0, 1);
            the_grid.Children.Add(txtEmail, 0, 3);
            the_grid.Children.Add(txtPassword, 0, 5);
            the_grid.Children.Add(txtPhoneNumber, 0, 4);
            #endregion

            #region childStack_layout def
            StackLayout stack_layout = new StackLayout
            {
                BackgroundColor = Color.FromHex("#455A64"),
                Padding = 20,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    the_grid, btnSave
                }
            };
            #endregion

            Content = stack_layout;
        }

        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            //UserConnection uc = new UserConnection();
            //User newUser = new User();
            //newUser.fbID = "durini309";
            //newUser.username = "pinaconda";
            //newUser.firstname = "Juan Carlos";
            //newUser.lastname = "Durini";
            //newUser.picture_link = "www.google.com";
            //newUser.gender = "M";
            //newUser.location = "Guatemala";
            //newUser.birthday = Convert.ToDateTime("09/30/1994");
            //newUser.levelNumber = 100;
            //newUser.score = 999999;
            //newUser.Level = new Level();
            //uc.insertNewUser(newUser);
            //User newUser2 = uc.getUserByUsername("pinaconda");



        }
    }
}
