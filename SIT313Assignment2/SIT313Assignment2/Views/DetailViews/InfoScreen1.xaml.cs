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
	public partial class InfoScreen1 : ContentPage
	{
		public InfoScreen1 ()
		{
			InitializeComponent ();
            Init();
		}
        async void GameRecommend(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GameRecommend());
        }
        private void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            lbl_CPU.TextColor = Constants.MainTextColor;
            lbl_RAM.TextColor = Constants.MainTextColor;
            lbl_Graphicscard.TextColor = Constants.MainTextColor;
            lbl_SSD.TextColor = Constants.MainTextColor;
        }
    }
}