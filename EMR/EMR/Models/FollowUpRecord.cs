using System;
using System.Collections.Generic;
using System.Text;
using XLabs.Data;

namespace EMR.Pages
{
    class FollowUpRecord
    {
        private DateTime date { get; set; }
        private string text { get; set; }

        public FollowUpRecord(DateTime pDate, string pText)
        {
            this.date = pDate;
            this.text = pText;
        }

    }
}
