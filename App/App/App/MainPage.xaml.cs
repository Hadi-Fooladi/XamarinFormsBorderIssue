using System;
using Xamarin.Forms;

namespace App
{
	public partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_OnClicked(object sender, EventArgs e)
		{
			_contentView.Content = new Label();
			_contentView.Content = _roundedButton;
		}
	}
}
