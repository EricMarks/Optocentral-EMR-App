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
	public partial class Ocular_History : ContentPage
	{
		public Ocular_History ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("you want to save? ", "set","cancel");
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {

        }
    }
}