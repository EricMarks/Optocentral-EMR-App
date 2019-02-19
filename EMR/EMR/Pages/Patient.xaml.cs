using EMR.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EMR.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Patient : ContentPage
	{
		public Patient ()
		{
			InitializeComponent ();
		}

        private void Btn_NewRecord_Clicked(object sender, EventArgs e)
        {
            PatientViewModel _patientViewModel = new PatientViewModel();
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            _patientViewModel.CreatePatientAsync(Entry_LastName.Text, Entry_LastName.Text, DatePicker_DoB.Date, Picker_Gender.SelectedItem.ToString(), Entry_Street.Text, Entry_City.Text, Entry_State.Text, Convert.ToInt32(Entry_Zip.Text), Entry_Email.Text, Entry_Phone.Text, Entry_AditionalInformation.Text);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed

            DisplayAlert("Login", "Login Sucess", "Correct");
        }

        //private void Btn_NewRecord_ClickedAsync(object sender, EventArgs e)
        //{

        //    PatientViewModel _patientViewModel = new PatientViewModel();
        //   // await _patientViewModel.CreatePatientAsync(Entry_LastName.Text, Entry_LastName.Text, DatePicker_DoB.Date, Picker_Gender.SelectedItem.ToString(), Entry_Street.Text, Entry_City.Text, Entry_State.Text, Convert.ToInt32(Entry_Zip.Text), Entry_Email.Text, Entry_Phone.Text, Entry_AditionalInformation.Text);

        //}
    }
}