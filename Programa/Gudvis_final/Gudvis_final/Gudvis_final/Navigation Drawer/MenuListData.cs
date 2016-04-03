using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gudvis_final.Navigation_Drawer
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Title = "Profile",
                IconSource = "Profile.png",
                TargetType = typeof(Profile.Profile)
            });

            this.Add(new MenuItem()
            {
                Title = "Timeline",
                IconSource = "Timeline.png",
                TargetType = typeof(Timeline.Timeline)
            });

            this.Add(new MenuItem()
            {
                Title = "Followers",
                IconSource = "Followers.png",
                TargetType = typeof(Following_Follower.ViewFollowers)
            });

            this.Add(new MenuItem()
            {
                Title = "Following",
                IconSource = "Following.png",
                TargetType = typeof(Following_Follower.ViewFollowing)
            });

            this.Add(new MenuItem()
            {
                Title = "Events",
                IconSource = "Events.png",
                TargetType = typeof(Events.EventsMain)
            });

            this.Add(new MenuItem()
            {
                Title = "Settings",
                IconSource = "Settings.png",
                TargetType = typeof(Settings.Settings)
            });
        }
    }
}
