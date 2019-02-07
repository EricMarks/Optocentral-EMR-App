using EMR.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMR.ViewModel
{
    class UserViewModel
    {
        private DataService _DataService;

        public UserViewModel()
        {
            this._DataService = new DataService();
       
        }

        public Boolean CheckLogin(String UserName, String Password)
        {
            return  _DataService.CheckLogin(UserName, Password);
        }
        private async Task CreateUserAsync()
        {
            User _user = new User();
            _user.FirstName = "Carlos";
            _user.LastName = "Avalle";
            _user.Username = "carlosavalle";
            _user.Password = "123";
             _DataService.Insert(_user);
        }
    }
}
