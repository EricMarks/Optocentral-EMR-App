using EMR.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMR.ViewModel
{
   
    class FollowUpViewModel
    {
        public List<FollowUpRecord> FollowUpList { get; set; }

        public FollowUpViewModel()
        {
            FollowUpList = new List<FollowUpRecord>
            {
                new FollowUpRecord(DateTime.Now,"Carlos")

            };
        }
    }
}
