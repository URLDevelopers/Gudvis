﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Cards;
//using Xamarin.Forms;

//namespace Gudvis_final.Following_Follower
//{
//    class ViewFollowing : ContentPage
//    {
//        public ViewFollowing()
//        {
//            var cards = new CardData();

//            var cardstack = new StackLayout
//            {
//                Spacing = 15,
//                Padding = new Thickness(10),
//                VerticalOptions = LayoutOptions.StartAndExpand,
//            };

//            foreach (var card in cards)
//            {
//                cardstack.Children.Add(new CardView(card));
//            }

//            Title = "Following";
//            BackgroundColor = Color.White;
//            Content = new ScrollView()
//            {
//                Content = new StackLayout()
//                {
//                    Children = {
//                            cardstack
//                        }
//                }
//            };
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Gudvis_F.Following_Follower
{
    class ViewFollowing : ContentPage
    {
        public ViewFollowing()
        {

            Label id = new Label
            {
                Text = "This is your following page",
                TextColor = Color.Black,
                XAlign = TextAlignment.Center
            };

            BackgroundColor = Color.White;
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                        id
                        }
            };
        }
    }
}
