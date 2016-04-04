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

        public void getUser(User newUser)
        {
            actUser = newUser;
        }

        public RootPage()
        {
            menuPage = new MenuPage();
            menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as MenuItem);
            Master = menuPage;
            Detail = new Timeline.Timeline();
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
                //case "EventsMain":
                //    var newEvents = new Events.EventsMain();
                //    newEvents.getUser(actUser);
                //    Detail = new NavigationPage(newEvents);
                //    break;

                //case "Profile":
                //    var newProfile = new Profile.Profile();
                //     newProfile.getUser(actUser);
                //    Detail = new NavigationPage(newProfile);
                //    break;

                //case "Settings":
                //    var newSettings = new Settings.Settings();
                //    newSettings.getUser(actUser);
                //    Detail = new NavigationPage(newSettings);
                //    break;

                //case "Timeline":
                //    var newTimeline = new Timeline.Timeline();
                //    newTimeline.getUser(actUser);
                //    Detail = new NavigationPage(newTimeline);
                //    break;

                default:
                    Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);
                    Detail = new NavigationPage(displayPage);
                    break;
            }
            

            menuPage.Menu.SelectedItem = null;
            IsPresented = false;
        }
    }
}
