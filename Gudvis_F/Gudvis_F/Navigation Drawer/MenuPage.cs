using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Gudvis_F.Navigation_Drawer
{
    public class MenuPage : ContentPage
    {
        public ListView Menu { get; set; }

        public MenuPage()
        {
            Icon = "menu.png";
            Title = "menu"; // The Title property must be set.
            BackgroundColor = Color.FromHex("F5F5F5");

            Menu = new MenuListView();

            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            layout.Children.Add(Menu);

            Content = layout;
        }
    }
}
