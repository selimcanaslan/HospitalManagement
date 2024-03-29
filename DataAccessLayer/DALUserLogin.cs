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
            public DataTable fetchUserData(string username, string password, string auth_type)
            {
                string query = "EXEC fetch_user_data " + username + "," + password + "," + auth_type;
                return _dalCommon.DTable(query);
            }
        }
    }
