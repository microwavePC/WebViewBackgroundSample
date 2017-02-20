using WebViewBackgroundSample;
using WebViewBackgroundSample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace WebViewBackgroundSample.Droid
{
	public class CustomWebViewRenderer : WebViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
		{
			base.OnElementChanged(e);
			this.Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
		}
	}
}
