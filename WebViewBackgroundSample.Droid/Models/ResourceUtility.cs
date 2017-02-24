using WebViewBackgroundSample.Models.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(ResourceUtility))]
namespace WebViewBackgroundSample.Models.Droid
{
	public class ResourceUtility : IResourceUtility
	{
		public string GetHtmlFileRootPath()
		{
			return "file:///android_asset/";
		}
	}
}
