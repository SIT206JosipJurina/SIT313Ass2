﻿using SIT313Assignment2.Models;
using SIT313Assignment2.Views.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIT313Assignment2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
       

        public LoginPage ()
		{
			InitializeComponent ();
            Init();
           
        }

        private void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);

        }

        public async void SignInProcedure(object sender, EventArgs e)
        {            
            User user = new User(Entry_Username.Text, Lbl_Password.Text);
            Entry_Username.Text = "";
            Entry_Password.Text = "";
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "Ok");
                var result = new Token();
                if (result != null)
                {
                   // App.UserDatabase.SaveUser(user);
                   // App.TokenDatabase.SaveToken(result);

                   // await Navigation.PushAsync(new Dashboard());
                    if (Device.OS == TargetPlatform.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new Dashboard());
                    }
                    else if (Device.OS == TargetPlatform.iOS)
                    {
                        await Navigation.PushModalAsync(new NavigationPage(new Dashboard()));
                    }
                }
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct, empty Username or Password.", "Ok");
            }
        }
	}
}