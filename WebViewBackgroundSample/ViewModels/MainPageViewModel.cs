using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;
using WebViewBackgroundSample.Models;

namespace WebViewBackgroundSample.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private string _url;
		public string Url
		{
			get { return _url; }
			set { SetProperty(ref _url, value); }
		}

		private readonly IHtmlLoader _htmlLoader;

		public ICommand ChangeBackgroundMatrixCommand { get; }
		public ICommand ChangeBackgroundTransmissionCommand { get; }
		public ICommand ChangeBackgroundBlankCommand { get; }

		public MainPageViewModel(IHtmlLoader htmlLoader)
		{
			_htmlLoader = htmlLoader;

			ChangeBackgroundMatrixCommand = new DelegateCommand(() => {
				Url = _htmlLoader.GetHtmlFileRootPath() + "Background_Matrix.html";
			});

			ChangeBackgroundTransmissionCommand = new DelegateCommand(() =>
			{
				Url = _htmlLoader.GetHtmlFileRootPath() + "Background_Transmission.html";
			});

			ChangeBackgroundBlankCommand = new DelegateCommand(() =>
			{
				Url = _htmlLoader.GetHtmlFileRootPath() + "Background_Blank.html";
			});
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{

		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			
		}
	}
}

