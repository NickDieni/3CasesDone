using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_3Cases
{
    public class Kode
    {
        //Lavet get set for password
        private string _password;
        public string GetSetkode
        {
            get { return _password; }
            set { _password = value; }
        }


    }
    public class User
    {
        //Lavet get set for user
        private string _user;
        public string GetSetkode
        {
            get { return _user; }
            set { _user = value; }
        }
    }
}
