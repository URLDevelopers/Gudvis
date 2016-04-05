using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace F_Gudvis.Navigation_Drawer
{
    public class RootPage : MasterDetailPage
    {
        MenuPage menuPage;
        private User actUser;

        public RootPage(User newUser)
        {
            actUser = newUser;
            menuPage = new MenuPage();
            menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as MenuItem);
            Master = menuPage;
            Detail = new NavigationPage(new Timeline.Timeline(actUser))
            {
                BarBackgroundColor = Color.FromHex("#F44336")
            };
        }

        void NavigateTo(MenuItem menu)
        {
            if (menu == null)
                return;
            
            string[] separated = menu.TargetType.FullName.Split('.'); //Separate full name
            string pageName = separated[separated.Length - 1]; //Gets page name

            //This switch is used for sending the actual user to the new page.
            switch (pageName)
            {
                case "EventsMain":
                    var newEvents = new Events.EventsMain(actUser);
                    Detail = new NavigationPage(newEvents)
                    {
                        BarBackgroundColor = Color.FromHex("#FF5722") //Anaranjado
                    }; ;
                    break;

                case "Profile":
                    var newProfile = new Profile.Profile(actUser);
                    Detail = new NavigationPage(newProfile)
                    {
                        BarBackgroundColor = Color.FromHex("#009688") //verde
                    };
                    break;

                case "Settings":
                    var newSettings = new Settings.Settings(actUser);
                    Detail = new NavigationPage(newSettings)
                    {
                        BarBackgroundColor = Color.FromHex("#607D8B") //Gris obscuro
                    };
                    break;

                case "Timeline":
                    //var newTimeline = new Events.ViewEventsList(actUser);
                    var newTimeline = new Timeline.Timeline(actUser);
                    Detail = new NavigationPage(newTimeline)
                    {
                        BarBackgroundColor = Color.FromHex("#F44336") //Rojo
                    };

                    break;

                default:
                    Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);
                    Detail = new NavigationPage(displayPage)
                    {
                        BarBackgroundColor = Color.FromHex("#009688")
                    };
                    break;
            }

            menuPage.Menu.SelectedItem = null;
            IsPresented = false;
        }
    }
}
