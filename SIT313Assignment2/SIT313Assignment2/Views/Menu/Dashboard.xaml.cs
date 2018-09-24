using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SIT313Assignment2.Models;
using SIT313Assignment2.Views.DetailViews;

namespace SIT313Assignment2.Views.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Dashboard : ContentPage
	{
		public Dashboard ()
		{
			InitializeComponent ();
            Init();
		}
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            this.test.Text = App.UserDatabase.GetUser().Username;

        }
        async void SelectedScreen1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoScreen1());
        }
        async void SelectedScreen2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewsPage());
        }
        async void Logout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }


    }
}