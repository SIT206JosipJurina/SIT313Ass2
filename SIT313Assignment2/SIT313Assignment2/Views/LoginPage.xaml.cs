using SIT313Assignment2.Models;
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
            this.InitializeComponent();
            this.BindingContext = this;
            this.IsBusy = false;
            this.Btn_Signin.Clicked += Btn_Signin_Clicked;
            App.UserDatabase.DeleteUser(0);

            Init();
           
        }
        private void Btn_Signin_Clicked(object sender, EventArgs e)
        {
             this.IsBusy = true;
        }

        private void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            App.startcheckifinternet(lbl_NoInternet, this);

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);

        }

        public async void SignInProcedure(object sender, EventArgs e)
        {            
            User user = new User(Entry_Username.Text, Lbl_Password.Text);
            // Entry_Username.Text = "";
            // Entry_Password.Text = "";
           
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "Ok");
                // var result = new Token();
                
                App.UserDatabase.SaveUser(user);
                if (this.Entry_Username != null || this.Entry_Password != null)
                {
                    
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
                this.IsBusy = false;
                App.UserDatabase.DeleteUser(0);
            }
            
        }
	}
}