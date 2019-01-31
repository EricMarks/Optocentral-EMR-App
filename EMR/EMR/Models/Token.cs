using System;
using System.Collections.Generic;
using System.Text;

namespace EMR.Models
{
    public class Token
    {
        public int id { get; set; }
        public string access_taken { get; set; }
        public string error_description { get; set; }
        public DateTime expire_date { get; set; }

        public Token() { }
    }
}
