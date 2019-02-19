using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMR.Models
{
    class Patient
    {
        [PrimaryKey, AutoIncrement]
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string Gender { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZIP { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AditionalInformation { get; set; }
    }
}
