using System;

using Xamarin.Forms;

namespace Cards
{
	public class Card
	{
		public CardStatus Status { get; set; }

        public string Badge { get; set; }

        public string Nationality { get; set; }
    
        public string Username { get; set; }

        public string CompleteName { get; set; }

        public UriImageSource ProfilePicture { get; set; }

        public string Level { get; set; }
	}

	public enum CardStatus
	{
		Alert,
		Completed,
		Unresolved
	}
}