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
        public DataTable FetchUserPassword(string mail, string userType)
        {
            string loginTable = string.Empty;
            if (userType == "Secretary")
            {
                loginTable = "Secretary_Login_Info";
            }
            else if (userType == "Doctor")
            {
                loginTable = "Doctor_Login_Info";
            }
            string query = $"SELECT {loginTable}.password as 'password' FROM {userType} " +
                $"INNER JOIN {loginTable} ON {userType}.tc_no = {loginTable}.tc_no WHERE mail = '{mail}'";
            return _dalCommon.DTable(query);
        }
    }
}
