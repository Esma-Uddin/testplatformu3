using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testplatformu3
{

    internal class AdminController
    {
        private List<Admin> admins = new List<Admin>();

        public void AddAdmin(string username, string password)
        {
            var admin = new Admin { Username ="Esma", Password = "esma123" };
            admins.Add(admin);
            Console.WriteLine($"Admin login: {admin.Username}");
        }

        public bool Login(string username, string password)
        {
            var admin = admins.Find(a => a.Username == username && a.Password == password);
            return admin != null;
        }
    }
}