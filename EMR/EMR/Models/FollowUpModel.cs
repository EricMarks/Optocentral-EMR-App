using System;
using System.Collections.Generic;
using System.Text;

namespace EMR.Models
{

    public class FollowUpModel
    {
        private string date;
        private string text;

        public string Date
        {
            get { return date; }
            set { this.date = value; }
        }

        public string Text
        {
            get { return text; }
            set { this.text = value; }
        }

        public FollowUpModel (string date, string text)
        {
            this.date = date;
            this.text = text;
        }
    }
}
