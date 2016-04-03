using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cards;
using Xamarin.Forms;

namespace Gudvis_final.Following_Follower
{
    class ViewFollowers :ContentPage
    {
        public ViewFollowers()
        {
            var cards = new CardData();

            var cardstack = new StackLayout
            {
                Spacing = 15,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.StartAndExpand,
            };

            foreach (var card in cards)
            {
                cardstack.Children.Add(new CardView(card));
            }

            Title = "Followers";
            BackgroundColor = Color.White;
            Content = new ScrollView()
            {
                Content = new StackLayout()
                {
                    Children = {
                            cardstack
                        }
                }
            };
        }
    }
}
