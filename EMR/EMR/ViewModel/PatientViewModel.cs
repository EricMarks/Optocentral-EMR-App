using EMR.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMR.ViewModel
{
    class PatientViewModel
    {
        private DataService _DataService;

        public PatientViewModel()
        {
            this._DataService = new DataService();

        }

      
        public async Task CreatePatientAsync(String pFristName,String pLastName,DateTime pDoB, String pGender, String pStreet, String pCity, String pState, int pZIP, String pEmail, String pPhone, String pAditionalInformation )
        {
            Patient _Patient = new Patient();
            _Patient.FirstName = pFristName;
            _Patient.LastName = pLastName;
            _Patient.DoB = pDoB;
            _Patient.Gender = pGender;
            _Patient.Street = pStreet;
            _Patient.City = pCity;
            _Patient.State = pState;
            _Patient.ZIP = pZIP;
            _Patient.Email = pEmail;
            _Patient.Phone = pPhone;
            _Patient.AditionalInformation = pAditionalInformation;

            await _DataService.Insert(_Patient);

  
    }
    }
}
