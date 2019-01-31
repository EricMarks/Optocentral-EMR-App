using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EMR.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_UserName.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Passwrod.Focus();
            Entry_Passwrod.Completed += (s, e) => SignInProceduce(s, e);
        }

        void SignInProceduce(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Passwrod.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Sucess", "Correct");
            }
            else
            {
                DisplayAlert("Login", "Login Not Sucess, or empty username or password", "Imcorrect");
            }
        }
    }
}