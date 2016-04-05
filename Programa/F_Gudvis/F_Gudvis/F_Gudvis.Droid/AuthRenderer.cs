using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Json;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using F_Gudvis;
using F_Gudvis.Navigation_Drawer;
using F_Gudvis.Log_In;
using F_Gudvis.Droid;
using Xamarin.Auth;

[assembly: ExportRenderer(typeof(Auth), typeof(AuthRenderer))]

namespace F_Gudvis.Droid
{
    class AuthRenderer : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            var user = new User(); //adding new instance of a user

            // this is a ViewGroup - so should be able to load an AXML file and FindView<>
            var activity = this.Context as Activity;

            var auth = new OAuth2Authenticator(
                clientId: "1701600820117263", // your OAuth2 client id
                scope: "", // The scopes for the particular API you're accessing. The format for this will vary by API.
                authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"), // the auth URL for the service
                redirectUrl: new Uri("http://www.facebook.com/connect/login_success.html")); // the redirect URL for the service

            auth.Completed += async (object sender, AuthenticatorCompletedEventArgs ee) =>
            {
                if (ee.IsAuthenticated)
                {
                    // Use eventArgs.Account to do wonderful things
                    //App.saveToken(ee.Account.Properties["access_token"]);
                    //App.successfulLogin();

                    // Now that we're logged in, make a OAuth2 request to get the user's id.
                    var request = new OAuth2Request("GET",
                        new Uri("https://graph.facebook.com/me?fields=picture,id,name,age_range,birthday,currency,email,first_name,gender,last_name,link,location"),
                        null, ee.Account);
                    var response = await request.GetResponseAsync(); //asyn request to Facebook's servers
                    var userData = JsonValue.Parse(response.GetResponseText()); //getting response with data

                    //lets save the data from the request in the previously created instance
                    string jsonImage = userData["picture"].ToString().Replace("\"", "");
                    string[] separated = jsonImage.Split(',');
                    user.picture_link = separated[1].Substring(6).Replace("}}", "");
                    user.fbID = userData["id"].ToString().Replace("\"", "");
                    //user.birthday = userData["birthday"];
                    user.firstname = userData["first_name"].ToString().Replace("\"", "");
                    user.gender = userData["gender"].ToString().Replace("\"", "");
                    user.lastname = userData["last_name"].ToString().Replace("\"", "");
                    //user.location = userData["location"];

                    F_Gudvis.UserConnection uc = new UserConnection();
                    User searchedUser = uc.getUserByFBId(user.fbID);
                    if (searchedUser == null)
                    {
                        //It means that user name needs to be created
                        var page = new Username(user);
                        App.Current.MainPage = page;
                    }
                    else
                    {
                        //It means that user name exists
                        var page = new Navigation_Drawer.RootPage(user);
                        App.Current.MainPage = page;
                    }



                }
                else {
                    // The user cancelled 

                }
            };

            activity.StartActivity(auth.GetUI(activity));
        }
    }
}