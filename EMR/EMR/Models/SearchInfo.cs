using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EMR.Models
{
    public class SearchInfo : INotifyPropertyChanged
    {
        private int dob;
        private string idNum;
        private string lastName;
        private string firstName;

        public int DOB
        {
            get { return dob; }
            set
            {
                this.dob = value;
                RaisePropertyChanged("DOB");
            }
        }

        public string IDNum
        {
            get { return idNum; }
            set
            {
                this.idNum = value;
                RaisePropertyChanged("IDNumber");
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                this.lastName = value;
                RaisePropertyChanged("LastName");
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                this.firstName = value;
                RaisePropertyChanged("FirstName");
            }
        }

        public SearchInfo(int dob, string idNum, string lastName, string firstName)
        {
            this.DOB = dob;
            this.IDNum = idNum;
            this.LastName = lastName;
            this.FirstName = firstName;

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
