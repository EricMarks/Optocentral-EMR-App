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
	public partial class Others : ContentPage
	{
		public Others ()
		{
			InitializeComponent ();
		}

        List<FollowUpRecord> followRecords = new List<FollowUpRecord>();        

        private void Btn_AddFollowUp_Clicked(object sender, EventArgs e)
        {
            followRecords.Add(new FollowUpRecord(DateTime.Today, Entry_followUp.Text));
            Entry_followUp.Text = "";
           
        }
    }
}