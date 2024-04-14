using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BlSecretary
    {
        private DALSecretary _dalSecretary;
        private DbConnect _dbConnect;
        public BlSecretary()
        {
            _dbConnect = new DbConnect();
            _dalSecretary = new DALSecretary();
        }
        public bool AddSecretary(string name, string surname, string tc_no, string mail, string phone_number, string address)
        {
            return _dalSecretary.AddSecretary(name, surname, tc_no, mail, phone_number, address);
        }
        public DataTable fetchAllSecretary()
        {
            return _dalSecretary.fetchAllSecretary();
        }
        public DataTable fetchSecretaryByGivenName(string name)
        {
            return _dalSecretary.fetchSecretaryByGivenName(name);
        }
        public bool deleteSecretary(string phone_number)
        {
            return _dalSecretary.deleteSecretary(phone_number);
        }
    }
}
