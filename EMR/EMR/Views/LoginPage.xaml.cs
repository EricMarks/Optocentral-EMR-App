using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.Models;
using EMR.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EMR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
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
            Entry_Passwrod.Completed +=  (s, e) =>  SignInProceduce(s, e);
        }

         void SignInProceduce(object sender, EventArgs e)
        {
            //UserViewModel _userViewModel = new UserViewModel();
            //User user = new User();
            //_userViewModel.CheckLogin(Entry_Username.Text, Entry_Passwrod.Text
            if (true)
            {

                DisplayAlert("Login", "Login Sucess", "Correct");
                this.Navigation.PushModalAsync(   new MainPage());
               
            }
            //else
            //{

                 //DisplayAlert("Login", "Login Not Sucess, or empty username or password", "Imcorrect");
           // }
          
        }
    }
}