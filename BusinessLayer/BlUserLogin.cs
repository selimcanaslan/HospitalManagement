using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BlUserLogin
    {
        private DALUserLogin _dalUserLogin;

        public BlUserLogin()
        {
            _dalUserLogin = new DALUserLogin();
        }
        public DataTable fetchUserLoginData(string username, string password, string auth_type)
        {
            return _dalUserLogin.fetchUserData(username, password, auth_type);
        }
    }
}
