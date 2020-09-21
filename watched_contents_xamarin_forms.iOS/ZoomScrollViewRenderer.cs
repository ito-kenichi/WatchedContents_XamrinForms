using System;
using System.Linq;
using UIKit;
using watched_contents_xamarin_forms.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ScrollView), typeof(ZoomScrollViewRenderer))]
namespace watched_contents_xamarin_forms.iOS
{
    public class ZoomScrollViewRenderer : ScrollViewRenderer
    {
        public ZoomScrollViewRenderer()
        {
        }

        // bool zoomEnabled = false;
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            MaximumZoomScale = 3f;
            MinimumZoomScale = 1.0f;

        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            if (Subviews.Length > 0)
            {
                ViewForZoomingInScrollView += GetViewForZooming;
            }
            else
            {
                ViewForZoomingInScrollView -= GetViewForZooming;
            }

        }

        public UIView GetViewForZooming(UIScrollView sv)
        {
            return this.Subviews.FirstOrDefault();
        }
    }
}
