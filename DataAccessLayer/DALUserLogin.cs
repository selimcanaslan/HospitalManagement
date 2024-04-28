using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALUserLogin
    {
        public DALCommon _dalCommon;
        public DALUserLogin()
        {
            DbConnect dbConnect = new DbConnect();
            _dalCommon = new DALCommon();
        }
        public DataTable FetchSecretaryLoginInfo(string username, string password)
        {
            string query = "EXEC fetch_secretary_login_data " + username + "," + password;
            return _dalCommon.DTable(query);
        }
        public DataTable FetchDoctorLoginInfo(string username, string password)
        {
            string query = "EXEC fetch_doctor_login_data " + username + "," + password;
            return _dalCommon.DTable(query);
        }
    }
}
