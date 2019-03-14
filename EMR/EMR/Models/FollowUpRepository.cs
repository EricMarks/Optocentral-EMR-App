using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EMR.Models
{
    public class FollowUpRepository
    {
        private ObservableCollection<FollowUpModel> followUp;

        public FollowUpRepository()
        {
            followUp = new ObservableCollection<FollowUpModel>();
        }

        public ObservableCollection<FollowUpModel> GenerateFollowUp()
        {

            followUp.Add(new FollowUpModel("03/13/2019", "Changed Contacts"));

            return followUp;
        }
    }
}
