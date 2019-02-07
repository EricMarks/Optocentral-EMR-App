
[assembly: Xamarin.Forms.Dependency(typeof(EMR.Droid.Implementations.DBPath))]
namespace EMR.Droid.Implementations
{
    
    using System.IO;
    using System;
    using EMR.Models;

    public class DBPath : IServices
    {
       
        public string GetDBPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    
            return Path.Combine(path, "EMR.db3");
        }
    }
}