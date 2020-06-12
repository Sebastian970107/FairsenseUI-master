using FairsenseUI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FairsenseUI
{
	/// <summary>
	/// LoginWindow.xaml 的交互逻辑
	/// </summary>
	public partial class LoginWindow : Window
	{
		public LoginWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			if (Settings.Default.RememberMe == true)
			{
				this.RememberMeBox.IsChecked = true;
				this.UserNameBox.Text = Settings.Default.UserName;
				this.PasswordBox.Password = Settings.Default.PassWord;
			}
			if (Settings.Default.AutoLogin == true)
			{
				MainWindow mainWindow = new MainWindow();
				this.Close();
				mainWindow.Show();
			}
		}

		private void LoginButton_Click(object sender, RoutedEventArgs e)
		{
			string username = this.UserNameBox.Text;
			string password = this.PasswordBox.Password;
			//校验数据库的用户名密码
			if (true)
			{
				Settings.Default.UserName = username; // 记住账号			
				if (RememberMeBox.IsChecked == true)
				{
					//记住密码
					Settings.Default.PassWord = password;
					Settings.Default.RememberMe = true;
				}
				else
				{
					//取消记住状态
					Settings.Default.PassWord = "";
					Settings.Default.RememberMe = false;
				}
				if (AutoLoginBox.IsChecked == true)
				{
					Settings.Default.AutoLogin = true;
				}
				else
				{
					Settings.Default.AutoLogin = false;
				}
				Settings.Default.Save(); // 保存数据
				new MainWindow(); MainWindow mainWindow = new MainWindow();
				this.Close();
				mainWindow.Show();
			}
			else
			{
				System.Windows.Forms.MessageBox.Show("登录失败，账号或密码错误！", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
			}
		}	
	}
}
