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
        private string lastname;
        private string firstName;
        private string dateOfB;
        private int phoneNum;
        private string address;

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
                RaisePropertyChanged("ID Number");
            }
        }

        public string LastName
        {
            get { return lastname; }
            set
            {
                this.lastname = value;
                RaisePropertyChanged("Last Name");
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                this.firstName = value;
                RaisePropertyChanged("First Name");
            }
        }

        public string DateOfBirth
        {
            get { return dateOfB; }
            set
            {
                this.dateOfB = value;
                RaisePropertyChanged("Date of Birth");
            }
        }

        public int PhoneNum
        {
            get { return phoneNum; }
            set
            {
                this.phoneNum = value;
                RaisePropertyChanged("Phone Number");
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                this.address = value;
                RaisePropertyChanged("Address");
            }
        }

        public SearchInfo(int dob, string idNum, string name, string firstName, string dateOfB, int phoneNum, string address)
        {
            this.DOB = dob;
            this.IDNum = idNum;
            this.LastName = name;
            this.FirstName = firstName;
            this.DateOfBirth = dateOfB;
            this.PhoneNum = phoneNum;
            this.Address = address;

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
