using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace FairsenseUI.Controls
{
	/// <summary>
	/// WebOfFairsense.xaml 的交互逻辑
	/// </summary>
	public partial class WebOfFairsense : UserControl
	{
		public WebOfFairsense()
		{
			InitializeComponent();
		}

		private void UserControl_Loaded(object sender, RoutedEventArgs e)
		{
			Browser.Opacity = 0;
			Browser.Load("http://aqmap.fairsense.cn/login.html");
		}

		private void Browser_FrameLoadEnd(object sender, CefSharp.FrameLoadEndEventArgs e)
		{
			
			string JsCommand = "document.getElementById('name').value='xsxm1234';document.getElementById('pwd').value='xsxm1234'";
			Browser.GetBrowser().MainFrame.ExecuteJavaScriptAsync(JsCommand);
			Browser.GetBrowser().MainFrame.ExecuteJavaScriptAsync("document.querySelector(\"#container > section.sign.expanded > div > div > form > div.form-buttons > button:nth-child(1)\").onclick()");

			if (Browser.GetBrowser().MainFrame.Url == "http://aqmap.fairsense.cn/index.html" || Browser.GetBrowser().MainFrame.Url == "http://aqmap.fairsense.cn")
			{
				Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, new Action(() => { this.Browser.Opacity = 1; }));
				Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, new Action(() => { this.waitImg.Visibility = Visibility.Collapsed; }));
			}
		}

		private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
		{
			((MediaElement)sender).Position = ((MediaElement)sender).Position.Add(TimeSpan.FromMilliseconds(1));
		}
	}
}
