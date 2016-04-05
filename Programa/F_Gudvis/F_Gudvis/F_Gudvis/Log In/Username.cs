using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace F_Gudvis.Log_In
{
    public class Username : ContentPage
    {
        private Label lblInfo, lblError;
        private Entry txtUsername;
        private Button btnCreate;
        private User actUser;
        private UserConnection uc = new UserConnection();

        public Username(User newUser)
        {
            actUser = newUser;
            lblInfo = new Label
            {
                Text = "Create an unique username",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 24,
                //FontAttributes = FontAttributes.Bold,
                FontFamily = Device.OnPlatform(
                    iOS: "MarkerFelt-thin",
                    Android: "sans-serif-light",
                    WinPhone: "Comic Sans Ms"
                )
            };

            txtUsername = new Entry
            {
                TextColor = Color.Black,
                Placeholder = "Enter a username",
                PlaceholderColor = Color.FromHex("#B6B6B6"),
                //BackgroundColor = Color.FromHex("#B6B6B6"),
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Entry)),
                FontFamily = Device.OnPlatform(
                    iOS: "MarkerFelt-thin",
                    Android: "sans-serif-light",
                    WinPhone: "Comic Sans Ms"
                )
            };

            txtUsername.TextChanged += TxtUsername_TextChanged;

            btnCreate = new Button
            {
                Text = "Create user",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("#727272")
            };

            btnCreate.Clicked += BtnCreate_Clicked;

            lblError = new Label
            {
                Text = "",
                TextColor = Color.Red,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 12
            };

            BackgroundColor = Color.White;
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    lblInfo, txtUsername, btnCreate,
                    lblError
                }
            };
        }


        bool btnCreateEnabled = false;

        #region Functionality Methods

        /// <summary>
        /// This function checks on the DB if an username exists.
        /// </summary>
        /// <param name="newUsername">
        ///     string typed by the user
        /// </param>
        /// <returns></returns>
        private bool doesThisUsernameExists(string newUsername)
        {
            bool exists = false;
            exists = !(uc.getUserByUsername(newUsername) == null); //If null is returned, it means that username does not exists
            return exists;
        }

        /// <summary>
        /// This method is used to save new user basic info.
        /// </summary>
        /// <param name="userName">
        ///     user's username
        /// </param>
        private void saveUser(string userName)
        {
            actUser.username = userName;
            //uc.insertNewUser(actUser);
        }

        /// <summary>
        /// This function is used to validate an username.
        /// </summary>
        /// <param name="newUsername">
        ///     string typed by the user
        /// </param>
        /// <returns></returns>
        private bool isThisUsernameCorrect(string newUsername)
        {
            if (newUsername.Length > 3)
            {
                Regex rgx1 = new Regex(@"^((_*)([a-zA-Z0-9]+)(_*))+$");
                bool flag = rgx1.IsMatch(newUsername);
                if (flag) //Means that username is correct
                    return true;
                else
                {
                    lblError.Text = "Sorry. only letters, numbers and '_' are allowed.";
                    return false;
                }
            }
            else
            {
                lblError.Text = "Please, create an username with at least 3 chars.";
                return false;
            }
        }
        #endregion

        #region components Methods
        /// <summary>
        /// This async method is used when the user clicks the "Create User" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void BtnCreate_Clicked(object sender, EventArgs e)
        {
            if (btnCreateEnabled == true)
            {
                string newUsername = this.txtUsername.Text;
                if (isThisUsernameCorrect(newUsername)) //Validates username spelling
                {
                    if (doesThisUsernameExists(newUsername) == false)
                    {
                        var answer = await DisplayAlert("Attention", "Do you want '" + newUsername + "' as your username?", "Yes", "No");
                        if (answer == false) //"No" was selected
                        {
                            txtUsername.Text = "";
                        }
                        else
                        {
                            saveUser(txtUsername.Text);
                            await DisplayAlert("Congratulations", "You're part of Gudvis now!", "Awesome");
                            var page = new Navigation_Drawer.RootPage(actUser);
                            App.Current.MainPage = page;

                        }
                    } else
                        await DisplayAlert("Attention", "Sorry, this username has been taken", "Try again");
                }
            }
        }

        /// <summary>
        /// This method is used when the user changes the username's field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblError.Text = "";
            if (txtUsername.Text.Length > 0)
            {
                btnCreate.BackgroundColor = Color.FromHex("#8BC34A"); //Activates btn
                btnCreateEnabled = true;
            }
            else
            {
                btnCreate.BackgroundColor = Color.FromHex("#B6B6B6"); //Activates btn
                btnCreateEnabled = true;
            }
        }
        #endregion

    }
}
