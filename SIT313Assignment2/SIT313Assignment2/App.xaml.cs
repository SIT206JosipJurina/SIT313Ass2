using SIT313Assignment2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SIT313Assignment2.Data;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace SIT313Assignment2
{
	public partial class App : Application
	{
        static TokenDataBaseController tokenDatabase;
        static UserDatabaseController userDatabase;

		public App ()
		{
			InitializeComponent();

			MainPage = new LoginPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public static UserDatabaseController UserDatabase
        {
            get
            {
                if(userDatabase == null)
                {
                    userDatabase = new UserDatabaseController();
                }
                return userDatabase;
            }
        }
        public static TokenDataBaseController TokenDatabase
        {
            get
            {
                if (tokenDatabase == null)
                {
                    tokenDatabase = new TokenDataBaseController();
                }
                return tokenDatabase;
            }
        }
    }
}
