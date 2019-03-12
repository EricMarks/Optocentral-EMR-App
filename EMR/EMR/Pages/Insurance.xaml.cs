using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EMR.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Insurance : ContentPage
    {
        List<string> insuranceCode = new List<string>
        {
            "Z01.00 Examination of eyes and vision", "H52.11 Myipia, right eye", "H52.12 Myopia, left eye", "H52.13 Myopia, bilateral", "H52.01 Hyperopia, right eye", "H52.02 Hyperopia, left eye",
            "H52.03 Hyperopia, bilateral", "H52.221 Regular Astigmatism, right eye", "H52.222 Regular Astigmatism, left eye", "H52.223 Regular Astigmatism, bilateral", "H52.4 Presbyopia",
            "H52.6 Other disorders of refraction", "H53.021 Refractive Amblyopia, right eye", "H53.022 Refractive Amblyopia, left eye", "H52.031 Strabismic Amblyopia, right eye",
            "H52.032 Strabismic Amblyopia, left eye", "H26.9 Posterior Capsular Opacification", "H25.11 Nuclear cataract, right eye", "H25.12 Nuclear cataract, left eye", "H25.13 Nuclear cataract, bilateral",
            "H25.011 Cortical cataract, right eye", "H25.012 Cortical cataract, left eye", "H25.013 Cortical cataract, bilateral", "H25.041 Posterior supcapsular cataract, right eye",
            "H25.042 Posterior subcapsular cataract, left eye", "H25.043 Posterior subcapsular cataract, bilateral", "H10.411 Giant Papillary Conjunctivitis, right eye", "H10.412 Giant Papillary Conjunctivitis, left eye",
            "H10.413 Giant Papillary Conjunctivitis, bilateral", "H18.821 Corneal disorder from contact lens, right eye", "H18.822 Corneal disorder from contact lens, left eye", "H18.823 Corneal disorder from contact lens, bilateral",
            "H11.31 Subconjunctival Heme, right eye", "H11.32 Subconjunctival Heme, left eye", "H10.31 Acute conjunctivitis, right eye", "H10.32 Acute conjunctivitis, left eye", "H10.33 Acute conjunctivitis, bilateral",
            "H43.811 Vitreous Detachment, right eye", "H43.812 Vitreous Detachment, left eye", "E11.9 Diabetes", "H35.371 Puckering of macula, right eye", "H35.372 Puckering of macula, left eye", "H35.30 Macular Degeneration",
            "H40.003 Glaucoma suspect, bilateral", "S05.01XA Corneal abrasion, right eye", "S05.02XA Corneal abrasion, left eye", "T15.01XA Corneal foreign body, right eye", "T15.02XA Corneal foreign body, left eye", "H16.401 Corneal neovascularization, right eye",
            "H16.402 Corneal neovascularization, left eye", "H16.403 Corneal neovascularization, bilateral", "H16.001 Corneal ulcer, right eye", "H16.002 Corneal ulcer, left eye", "H18.601 Keratoconus, right eye", "H18.602 Keratoconus, left eye",
            "H18.603 Keratoconus, bilateral", "H10.811 Pingueculitis, right eye", "H10.812 Pinguecultis, left eye", "H10.813 Pinguecultis, bilateral"
        };

        ObservableCollection<string> myInsurance = new ObservableCollection<string>();

        public Insurance()
        {
            InitializeComponent();
        }

        private void SuggesstionsInsuranceListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var code = e.Item as string;
            myInsurance.Add(code);

            InsuranceListView.ItemsSource = myInsurance;

            SuggesstionsInsuranceListView.IsVisible = false;
        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            var keyword = InsuranceSearchBar.Text;

            if (keyword.Length >= 1)

            {
                var suggestions = insuranceCode.Where(c => c.ToLower().Contains(keyword.ToLower()));
                //var s = from c in colors where c.Contains(keyword) select c;

                SuggesstionsInsuranceListView.ItemsSource = suggestions;

                SuggesstionsInsuranceListView.IsVisible = true;

            }
            else
            {
                SuggesstionsInsuranceListView.IsVisible = false;
            }
        }

        void InsuranceSearchBar_SearchButtonPressed(object sender, System.EventArgs e)
        {

        }
    }
}