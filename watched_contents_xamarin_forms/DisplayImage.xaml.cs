using System.Diagnostics;
using Xamarin.Forms;

namespace watched_contents_xamarin_forms
{
    public partial class DisplayImage : ScrollView
    {

        public DisplayImage()
        {
            InitializeComponent();
        }

        public DisplayImage(string path)
        {
            InitializeComponent();
            image.Source = ImageSource.FromResource(path);
        }
    }
}
