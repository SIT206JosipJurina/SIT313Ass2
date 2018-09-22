﻿using System;
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
		}
        async void GameRecommend(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GameRecommend());
        }
    }
}