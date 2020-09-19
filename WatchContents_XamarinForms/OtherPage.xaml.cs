using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace check_to_travel_xamarin_forms
{
    public partial class OtherPage : ContentPage
    {
        public OtherPage()
        {
            InitializeComponent();
            var productIndex = 0;
            for (int rowIndex = 0; rowIndex < 4; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < 3; columnIndex++)
                {
                    productIndex += 1;
                    var image = new Image
                    {
                        Source = ImageSource.FromResource("check_to_travel_xamarin_forms.images.image" + String.Format("{0:D3}", productIndex) + ".png"),
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center,
                        WidthRequest = 80,
                        HeightRequest = 80,
                    };
                    var label = new Label
                    {
                        HeightRequest = 100,
                        WidthRequest = 100,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center,
                        BackgroundColor = new Color(0, 0, 0),
                    };
                    var tapGestureRecognizer = new TapGestureRecognizer();
                    tapGestureRecognizer.Tapped += async (sender, e) =>
                    {
                        if (label.BackgroundColor.Equals(new Color(0, 0, 0)))
                        {
                            label.BackgroundColor = new Color(100, 100, 100);

                            Person person = new Person()
                            {
                                Name = "TEST PERSON"
                            };

                            //Add New Person
                            await App.SQLiteDb.SaveItemAsync(person);
                            await DisplayAlert("Success", "Person added Successfully", "OK");
                            //Get All Persons
                            var personList = await App.SQLiteDb.GetItemsAsync();
                            foreach (var personObj in personList)
                            {
                                Debug.WriteLine("person ID : " + personObj.PersonID);
                            }
                        }
                        else
                        {
                            label.BackgroundColor = new Color(0, 0, 0);

                            //Get Person
                            var person = await App.SQLiteDb.GetItemAsync(Convert.ToInt32("1"));
                            if (person != null)
                            {
                                //Delete Person
                                await App.SQLiteDb.DeleteItemAsync(person);
                                await DisplayAlert("Success", "Person Deleted", "OK");

                                //Get All Persons
                                var personList = await App.SQLiteDb.GetItemsAsync();
                                foreach (var personObj in personList)
                                {
                                    Debug.WriteLine("person ID : " + personObj.PersonID);
                                }
                            }
                        }
                    };
                    image.GestureRecognizers.Add(tapGestureRecognizer);
                    gridLayout.Children.Add(label, columnIndex, rowIndex);
                    gridLayout.Children.Add(image, columnIndex, rowIndex);
                }
            }
        }
    }
}
