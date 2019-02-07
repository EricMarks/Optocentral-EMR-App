using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using EMR.Models;
using System.Linq;
using System.IO;

namespace EMR.Models
{
    public class DataService
    {
       private SQLiteAsyncConnection connDB;

        public DataService() {
            //DB();
            DataAccess();
        }
        private SQLiteConnection connection;

        public void DataAccess()
        {
            var DBPath = DependencyService.Get<IServices>().GetDBPath();
            this.connection = new SQLiteConnection(DBPath);
            connection.CreateTable<User>();
        }
        

        private async Task DB()
        {
            
            var DBPath = DependencyService.Get<IServices>().GetDBPath();
            connDB = new SQLiteAsyncConnection(DBPath);
            await connDB.CreateTableAsync<User>().ConfigureAwait(false);
        }
        public async Task Insert <T> (T model)
        {
            await connDB.InsertAsync(model);
        }
        public async Task DelUsers()
        {
            var query = await connDB.QueryAsync<User>("Delete from user");
        }
        public async Task GetUser()
        {
            var query = await connDB.QueryAsync<User>("Select * from user");
            var array = query.ToArray();
            Console.Write(array.Count());
            var list = array.Select(p => new User
            { 
            Username = p.Username,
           


            }).ToList();
            
        }
        public async Task<Boolean> CheckLoginAsync(String UserName, String Password)
        {
           
            var query = await connDB.QueryAsync<User>("Select * from user where UserName =" + UserName + " and Password =" + Password + "");
            if (query.Count > 0)
            {
                return true;
            }
            return false;
        }

        public Boolean CheckLogin(String UserName, String Password)
        {
           
            var query = connection.Query<User>("Select * from user where Username = '"+UserName+"' and Password ='"+Password+"'");
            if (query.Count > 1)
            {
                return true;
            }
            return false;
        }
    }

   
}
