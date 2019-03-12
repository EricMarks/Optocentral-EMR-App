using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using EMR.Models;

namespace EMR.ViewModel
{
    public class SearchInfoViewModel
    {
        public ObservableCollection<SearchInfo> SearchInfo { get; set; }
        
        public SearchInfoViewModel()
        {
            this.SearchInfo = new ObservableCollection<SearchInfo>();
        }

        private void GenerateClients()
        {
            SearchInfo.Add(new Models.SearchInfo(0001, "AK00123", "Smith", "Tom"));
        }
    }
}
