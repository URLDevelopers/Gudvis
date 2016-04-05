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

        string description_ = "Youth For Global Goals Guatemala Forum es el evento de cierre de Y4GG Week." +
"Este evento es totalmente gratis y en él conoceremos y trabajaremos junto a pensadores y emprendedores para delinear como la juventud puede lograr el cumplimiento de No Pobreza(ODS#1), Educación de Calidad (ODS #4), y Reducción de Inequidades (ODS#10) en Guatemala para el año 2030." +
"Del 18 al 23 de Abril será la semana donde llevaremos Youth For Global Goals (Y4GG) a tu Universidad." +
"Ésta es la iniciativa de AIESEC que busca empoderar a la juventud a tomar acción hacia el cumplimiento de de los Objetivos de Desarrollo Sustentables(ODS)" +
"El propósito de Y4GG es activar el potencial de jóvenes alrededor del mundo conectando y movilizandolos mediante proyectos sociales multiculturales diseñados para apoyar la implementación de los ODS." +
"¿Qué es capaz de hacer un Chapín por el cumplimiento de las ODS en Guatemala? Depende de nosotros. Dá el primer paso, toma acción y asiste a Youth For Global Goals Forum Guatemala."
                      ;
        string name = "THE TREES!";
        string partner = "Partners";
        string number = "52349812";
        string address = "mi casa y tu casa";
        string email = "partner@mail.com";
        DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now;

        #region Class methods
        public string GetMonth(int n)
        {
            switch (n)
            {
                case 1:
                    return "Jan";
                case 2:
                    return "Feb";
                case 3:
                    return "Mar";
                case 4:
                    return "Apr";
                case 5:
                    return "May";
                case 6:
                    return "Jun";
                case 7:
                    return "Jul";
                case 8:
                    return "Agus";
                case 9:
                    return "Sep";
                case 10:
                    return "Oct";
                case 11:
                    return "Nov";
                case 12:
                    return "Dec";
            }
            return "";
        }

        public Color getColor()
        {
            Random r = new Random();
            int n = r.Next(1, 5);
            switch (n)
            {
                case 1:
                    return Color.FromHex("#F44336");
                case 2:
                    return Color.FromHex("#536DFE");
                case 3:
                    return Color.FromHex("#673AB7");
                case 4:
                    return Color.FromHex("#009688");
                case 5:
                    return Color.FromHex("#8BC34A");
                case 6:
                    return Color.FromHex("#FFA000");
                default:
                    return Color.FromHex("#00BCD4");

            }
        }
        #endregion

        public ViewEvent()
        {
            Label descriptionTitle = new Label
            {
                Text = "Description",
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("#969696"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontFamily = fontType
            };

            Image infoImage = new Image
            {
                Source = "information.png",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            };

            Image mailImage = new Image
            {
                Source = "email.png",
                //Aspect = Aspect.AspectFit
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            Image mapImage = new Image
            {
                Source = "map.png",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            Label description = new Label
            {
                Text = description_,
                TextColor = Color.FromHex("#969696"),
                FontFamily = fontType,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };

            Label startTime = new Label
            {
                Text = this.startTime.Hour.ToString() + ":" + this.startTime.Minute.ToString(),
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };

            Label endTime = new Label
            {
                Text = this.startTime.Hour.ToString() + ":" + this.startTime.Minute.ToString(),
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };

            Label startDate = new Label
            {
                Text = this.startTime.Date.ToString().Split(' ')[0],
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };


            Label day = new Label
            {
                Text = this.startTime.Day.ToString(),
                TextColor = Color.FromHex("#E91E63"),
                FontSize = 50,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };

            Label month = new Label
            {
                Text = this.startTime.DayOfWeek + " " + GetMonth(this.startTime.Month),
                TextColor = Color.FromHex("#E91E63"),
                FontSize = 10,
                FontAttributes = FontAttributes.Bold,
                VerticalTextAlignment = TextAlignment.End,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };

            Label endDate = new Label
            {
                Text = this.startTime.Date.ToString().Split(' ')[0],
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };

            Label phone = new Label
            {
                Text = number.ToString(),
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };
            Label lblAddress = new Label
            {
                Text = address,
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };

            Label email = new Label
            {
                Text = this.email,
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                FontFamily = fontType
            };


            Image icon = new Image
            {
                BackgroundColor = getColor()
                //Source = ImageSource.FromFile("gudvis2.jpg"),
                //Aspect = Aspect.Fill

            };

            Label eventName = new Label
            {
                Text = name,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold & FontAttributes.Italic,
                TextColor = Color.Black,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
                FontFamily = fontType

            };

            Label owner = new Label
            {
                Text = partner,
                VerticalTextAlignment = TextAlignment.End,
                HorizontalTextAlignment = TextAlignment.End,
                FontSize = 15,
                FontAttributes = FontAttributes.Bold & FontAttributes.Italic,
                TextColor = Color.Black,
                FontFamily = fontType
            };


            var informationGrid = new Grid
            {
                BackgroundColor = Color.FromHex("#FFFFFF"),
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto },//date,nombre
                    new RowDefinition { Height = GridLength.Auto },//owner
                    new RowDefinition { Height =  GridLength.Auto },//startdate,time
                    new RowDefinition { Height =  GridLength.Auto },//enddate,time
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },//column1
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }//column2
                }
            };


            informationGrid.Children.Add(day, 0, 0);//columna,fila
            informationGrid.Children.Add(month, 0, 0);//columna,fila
            informationGrid.Children.Add(eventName, 1, 0);

            informationGrid.Children.Add(owner, 0, 1);

            informationGrid.Children.Add(startDate, 0, 2);
            informationGrid.Children.Add(startTime, 1, 2);

            informationGrid.Children.Add(endDate, 0, 3);
            informationGrid.Children.Add(endTime, 1, 3);

            var email_phone_grid = new Grid
            {
                BackgroundColor = Color.White,
                Padding = 10,
                VerticalOptions = LayoutOptions.Start,
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(5, GridUnitType.Star) }
                }
            };

            email_phone_grid.Children.Add(mailImage, 0, 0);
            email_phone_grid.Children.Add(email, 1, 0);
            email_phone_grid.Children.Add(mapImage, 0, 1);
            email_phone_grid.Children.Add(lblAddress, 1, 1);


            StackLayout viewEvent = new StackLayout
            {
                BackgroundColor = Color.FromHex("#FFFFFF"),
                Children =
                {
                    informationGrid,
                    email_phone_grid
                }
            };


            var Grid_Background = new Grid
            {
                BackgroundColor = Color.White,
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(3, GridUnitType.Star) }
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }

                }
            };

            Grid_Background.Children.Add(icon, 0, 0);
            Grid_Background.Children.Add(viewEvent, 0, 1);

            Grid descriptionGrid = new Grid
            {
                BackgroundColor = Color.FromHex("#FAFAFA"),
                Padding = 10,
                VerticalOptions = LayoutOptions.Start,
                RowDefinitions =
                {
                    //new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                },

                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(5, GridUnitType.Star) }
                }
            };

            descriptionGrid.Children.Add(description, 1, 0);
            descriptionGrid.Children.Add(infoImage, 0, 0);

            Content = new ScrollView
            {
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = 1,

                Content = new StackLayout
                {
                    Children =
                    {
                        Grid_Background,
                        descriptionGrid,
                        new Button {
                            Text = "Confirm",
                            BackgroundColor =Color.FromHex("#E91E63"),
                            HorizontalOptions =LayoutOptions.Center,
                            VerticalOptions =LayoutOptions.Center,
                            FontFamily = fontType}

                    }

                }
            };
        }
    }
}
