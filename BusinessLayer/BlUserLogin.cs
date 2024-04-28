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
        public DataTable FetchSecretaryLoginInfo(string username, string password)
        {
            return _dalUserLogin.FetchSecretaryLoginInfo(username, password);
        }
        public DataTable FetchDoctorLoginInfo(string username, string password)
        {
            return _dalUserLogin.FetchDoctorLoginInfo(username, password);
        }
    }
}
