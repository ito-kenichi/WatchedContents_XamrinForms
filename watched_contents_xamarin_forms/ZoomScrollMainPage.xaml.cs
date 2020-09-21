using System;
using Xamarin.Forms;

namespace watched_contents_xamarin_forms
{
    public partial class ZoomScrollMainPage : ContentPage
    {
        private readonly string contentsId;

        public ZoomScrollMainPage()
        {
            InitializeComponent();
        }

        public ZoomScrollMainPage(string args)
        {
            InitializeComponent();
            this.contentsId = args;
            var displayImage = new DisplayImage("watched_contents_xamarin_forms.assets.images.image002.jpg");
            layout.Children.Add(displayImage);
        }

        async void OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}
