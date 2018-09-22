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
	public partial class GameRecommend : ContentPage
	{
		public GameRecommend ()
		{
			InitializeComponent ();
		}
        async void Configuration1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Configuration1());
        }

        async void Configuration2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Configuration2());
        }
    }
}