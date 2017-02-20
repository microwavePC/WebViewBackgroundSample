using System;
using Foundation;
using WebViewBackgroundSample.Models;
using WebViewBackgroundSample.Models.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(HtmlLoader))]
namespace WebViewBackgroundSample.Models.iOS
{
	public class HtmlLoader : IHtmlLoader
	{
		public string GetHtmlFileRootPath()
		{
			return NSBundle.MainBundle.BundleUrl.ToString();
		}
	}
}
