using EMR.Models;
using EMR.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace EMR.ViewModel
{

    public class FollowUpViewModel : INotifyPropertyChanged
    {
        private FollowUpRepository followUpRepository;
        private ObservableCollection<FollowUpModel> followUp;

        public FollowUpViewModel()
        {
            followUpRepository = new FollowUpRepository();
            GenerateRows();
        }

        public ObservableCollection<FollowUpModel> FollowUp
        {
            get { return followUp; }
            set
            {
                followUp = value;
                RaisePropertyChanged("FollowUp");
            }
        }

        private void GenerateRows()
        {
            followUp = followUpRepository.GenerateFollowUp();
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }


}
