using System;

using Xamarin.Forms;

namespace Cards
{
	public class IconLabelView : ContentView
	{
        string fontType = Device.OnPlatform(
                    iOS: "MarkerFelt-thin",
                    Android: "sans-serif-light",
                    WinPhone: "Comic Sans Ms"
                );

        public IconLabelView (string text)
		{
			BackgroundColor = StyleKit.CardFooterBackgroundColor;

			var label = new Label () {
				Text = text,
                FontFamily = fontType,
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
				TextColor = StyleKit.LightTextColor
			};

			var stack = new StackLayout () {
				Padding = new Thickness (5),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					label
				}
			};

			Content = stack;
		}
	}
}