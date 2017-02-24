using Foundation;
using WebViewBackgroundSample.Models.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(ResourceUtility))]
namespace WebViewBackgroundSample.Models.iOS
{
	public class ResourceUtility : IResourceUtility
	{
		public string GetHtmlFileRootPath()
		{
			return NSBundle.MainBundle.BundleUrl.ToString();
		}
	}
}
