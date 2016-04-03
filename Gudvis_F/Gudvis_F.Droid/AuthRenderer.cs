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
using Xamarin.Auth;
using Gudvis_F.Log_In;
using Gudvis_F.Droid;

[assembly: ExportRenderer(typeof(Auth), typeof(AuthRenderer))]

namespace Gudvis_F.Droid
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
                    user.picture_link = userData["picture"];
                    user.fbID = userData["id"];
                    user.birthday = userData["birthday"];
                    user.firstname = userData["first_name"];
                    user.gender = userData["gender"];
                    user.lastname = userData["last_name"];
                    user.location = userData["location"];


                    if (user.fbID == null)
                    {

                    }
                    else
                    {

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