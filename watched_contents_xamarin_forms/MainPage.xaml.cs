using System;
using Xamarin.Forms;

namespace watched_contents_xamarin_forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void OnItemSelected(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ZoomScrollMainPage("test"));
            DisplayImage.imagePath = "watched_contents_xamarin_forms.assets.images.image002.jpg";
        }
    }
}
