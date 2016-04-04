using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Cards
{
	public class CardData : List<Card>
	{
        
		public CardData ()
		{
            /*//Get to recibe data from users, the get has to return a list with users
            List<Users> friends = new List<Users>();
            foreach (Users friend in friends)
            {
                //access to each friend a build a card of them
            }*/
			Add (
				new Card () { 
					Status = CardStatus.Completed, 
					CompleteName = "Jeremy Smith",
					Username = "@jsmith", 
                    ProfilePicture = new UriImageSource { Uri = new Uri("http://bit.ly/1s07h2W") },
                    Level = "Lvl. 210",
                    Badge = "Reforest Jedi",
					Nationality = "Guatemalan",
				}
			);
            Add(
                new Card()
                {
                    Status = CardStatus.Completed,
                    CompleteName = "Sara Kingston",
                    Username = "@skingston",
                    ProfilePicture = new UriImageSource { Uri = new Uri("http://bit.ly/1EhFsao") },
                    Level = "Lvl. 25",
                    Badge = "Recycle wonderwoman",
                    Nationality = "Brazilian",
                }
            );

            Add(
                new Card()
                {
                    Status = CardStatus.Completed,
                    CompleteName = "James Carter",
                    Username = "@jcarter",
                    ProfilePicture = new UriImageSource { Uri = new Uri("http://bit.ly/1rYGvGU") },
                    Level = "Lvl. 120",
                    Badge = "Partner",
                    Nationality = "Mexican",
                }
            );
            Add(
                new Card()
                {
                    Status = CardStatus.Completed,
                    CompleteName = "Elliot Johnson",
                    Username = "@ejohnson",
                    ProfilePicture = new UriImageSource { Uri = new Uri("http://bit.ly/1vCRbKh ") },
                    Level = "Lvl. 20",
                    Badge = "Garbage Sith",
                    Nationality = "Venezuelan",
                }
            );
            Add(
                new Card()
                {
                    Status = CardStatus.Completed,
                    CompleteName = "Jeff Alexander",
                    Username = "@jalexander",
                    ProfilePicture = new UriImageSource { Uri = new Uri("http://bit.ly/1rPp1vm") },
                    Level = "Lvl. 10",
                    Badge = "Tree enthusiast",
                    Nationality = "American",
                }
            );
            Add(
             new Card()
             {
                 Status = CardStatus.Completed,
                 CompleteName = "Boby Fisher",
                 Username = "@bfisher",
                 ProfilePicture = new UriImageSource { Uri = new Uri("http://bit.ly/1sXguu1") },
                 Level = "Lvl. 32",
                 Badge = "Poverty master jedi",
                 Nationality = "Cuban",
             }
         );
        }
	}
}