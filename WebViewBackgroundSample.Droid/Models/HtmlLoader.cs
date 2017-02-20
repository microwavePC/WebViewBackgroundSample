using WebViewBackgroundSample.Models;
using WebViewBackgroundSample.Models.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(HtmlLoader))]
namespace WebViewBackgroundSample.Models.Droid
{
	public class HtmlLoader : IHtmlLoader
	{
		public string GetHtmlFileRootPath()
		{
			return "file:///android_asset/";
		}
	}
}
