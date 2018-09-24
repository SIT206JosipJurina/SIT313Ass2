using SIT313Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIT313Assignment2.Views.DetailViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewsPage : ContentPage
	{
		public NewsPage ()
		{
			InitializeComponent ();
            Init();
		}
        async void Logout1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        private void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            txt1.TextColor = Constants.MainTextColor;
            txt2.TextColor = Constants.MainTextColor;
            txt3.TextColor = Constants.MainTextColor;
        }
    }
}