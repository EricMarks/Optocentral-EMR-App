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

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
