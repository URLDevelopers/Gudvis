using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace F_Gudvis.Events
{
    class ViewEvent : ContentPage
    {
        string fontType = Device.OnPlatform(
                    iOS: "MarkerFelt-thin",
                    Android: "sans-serif-light",
                    WinPhone: "Comic Sans Ms"
                );

        public ViewEvent()
        {
            Label description = new Label
            {
                Text = "Description",
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.White,
                FontFamily = fontType
            };

            Label descriptionValue = new Label
            {
                Text = "Hi we want to invite you to \"SAVE THE TREES\" this event is going to be in Guatemala, zona 10, /n  Hi we want to invite you to \"SAVE THE TREES\" this event is going to be in Guatemala, zona 10,   Hi we want to invite you to \"SAVE THE TREES\" this event is going to be in Guatemala, zona 10,  Hi we want to invite you to \"SAVE THE TREES\" this event is going to be in Guatemala, zona 10, we want to invite you to \"SAVE THE TREES\" this event is going to be in Guatemala, zona 10,Hi we want to invite you to \"SAVE THE TREES\" this event is going to be in Guatemala, zona 10"
                            ,
                TextColor = Color.Black,
                FontFamily = fontType
            };


            Label time = new Label
            {
                Text = "HORA",
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };



            Label startDate = new Label
            {
                Text = "fecha inicio",
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };

            Label startDateValue = new Label
            {
                Text = "marzo - 2016",
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };

            Label startTime = new Label
            {
                Text = "22:00 pm",
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };


            Label endDate = new Label
            {

                Text = "fecha fin",
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };

            Label endDateValue = new Label
            {

                Text = "abril-2016",
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };

            Label endTime = new Label
            {
                Text = "00:00 pm",
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };

            Label phone = new Label
            {
                Text = "Phone",
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };

            Label phoneValue = new Label
            {
                Text = "58230492",
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };
            Label email = new Label
            {
                Text = "Email",
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };

            Label emailValue = new Label
            {
                Text = "ji238ji@gmail.com",
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };

            Image icon = new Image
            {
                BackgroundColor = Color.FromHex("#00796B")

            };

            Label eventName = new Label
            {
                Text = "TREES",
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 35,
                FontAttributes = FontAttributes.Bold & FontAttributes.Italic,
                TextColor = Color.White,
                FontFamily = fontType

            };

            Label owner = new Label
            {
                Text = "Gudvis",
                VerticalTextAlignment = TextAlignment.End,
                HorizontalTextAlignment = TextAlignment.End,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold & FontAttributes.Italic,
                TextColor = Color.White,
                FontFamily = fontType

            };

            var Grid_Content = new Grid
            {
                BackgroundColor = Color.FromHex("#FFFFFF"),
                Padding = 20

            };

            Grid_Content.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });//startdate,time
            Grid_Content.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });//values
            Grid_Content.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });//enddate,time
            Grid_Content.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });//values
            Grid_Content.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });//email,phone
            Grid_Content.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });//column1
            Grid_Content.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });//column2

            Grid_Content.Children.Add(startDate, 0, 0);//columna,fila
            Grid_Content.Children.Add(time, 1, 0);
            Grid_Content.Children.Add(startDateValue, 0, 1);
            Grid_Content.Children.Add(startTime, 1, 1);

            Grid_Content.Children.Add(endDateValue, 0, 2);
            Grid_Content.Children.Add(endTime, 1, 2);

            Grid_Content.Children.Add(email, 0, 3);
            Grid_Content.Children.Add(phone, 1, 3);
            Grid_Content.Children.Add(emailValue, 0, 4);
            Grid_Content.Children.Add(phoneValue, 1, 4);




            var Grid_Background = new Grid
            {
                Padding = 1
            };

            Grid_Background.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            Grid_Background.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
            Grid_Background.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });




            var Scroll = new ScrollView
            {
                BackgroundColor = Color.FromHex("#9E9E9E"),
                Content = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    Children =
                    {
                        Grid_Content,
                        description,
                        descriptionValue
                    }
                }

            };

            Grid_Background.Children.Add(icon, 0, 0);
            Grid_Background.Children.Add(eventName, 0, 0);
            Grid_Background.Children.Add(owner, 0, 0);
            Grid_Background.Children.Add(Scroll, 0, 1);

            Content = new StackLayout
            {
                Children =
                {
                    Grid_Background
                }
            };
        }
    }
}
