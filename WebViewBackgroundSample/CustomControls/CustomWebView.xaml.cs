using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace WebViewBackgroundSample
{
	public partial class CustomWebView : WebView
	{
		public CustomWebView()
		{
			InitializeComponent();
		}

		// 背景色を透明にする処理
		public delegate void SetBackgroundColorTransparentHandler();
		public SetBackgroundColorTransparentHandler SetBackgroundColorTransparent;
	}
}
