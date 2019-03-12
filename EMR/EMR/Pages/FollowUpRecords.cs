using System;
using System.Collections.Generic;
using System.Text;

namespace EMR.Pages
{
    class FollowUpRecords
    {
        private DateTime date;
        private string text;

        public FollowUpRecords(DateTime date, string text)
        {
            this.date = date;
            this.text = text;
        }
    }
}
