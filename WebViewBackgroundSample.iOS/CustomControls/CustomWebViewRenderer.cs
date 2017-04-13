using UIKit;
using WebViewBackgroundSample;
using WebViewBackgroundSample.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace WebViewBackgroundSample.iOS
{
	public class CustomWebViewRenderer : WebViewRenderer
	{
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);
			this.Opaque = false;
			this.BackgroundColor = UIColor.Clear;
		}
	}
}
