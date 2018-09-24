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
	public partial class Configuration1 : ContentPage
	{
		public Configuration1 ()
		{
			InitializeComponent ();
            Init();
		}
        private void Init()
        {
            BackgroundColor = Constants.BackgroundColor;

        }
        async void SelectedScreen2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewsPage());
        }
    }
}