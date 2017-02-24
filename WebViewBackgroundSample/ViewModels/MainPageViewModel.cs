﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;
using WebViewBackgroundSample.Models;

namespace WebViewBackgroundSample.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		private string _localHtmlFileRootPath;

		private string _url;
		public string Url
		{
			get { return _url; }
			set { SetProperty(ref _url, value); }
		}

		private readonly IResourceUtility _resourceUtility;

		public ICommand ChangeBackgroundMatrixCommand { get; }
		public ICommand ChangeBackgroundTransmissionCommand { get; }
		public ICommand ChangeBackgroundBlankCommand { get; }

		public MainPageViewModel(IResourceUtility htmlLoader)
		{
			_resourceUtility = htmlLoader;
			_localHtmlFileRootPath = _resourceUtility.GetHtmlFileRootPath();

			ChangeBackgroundMatrixCommand = new DelegateCommand(() => {
				Url = _localHtmlFileRootPath + "Background_Matrix.html";
			});

			ChangeBackgroundTransmissionCommand = new DelegateCommand(() =>
			{
				Url = _localHtmlFileRootPath + "Background_Transmission.html";
			});

			ChangeBackgroundBlankCommand = new DelegateCommand(() =>
			{
				Url = _localHtmlFileRootPath + "Background_Blank.html";
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

