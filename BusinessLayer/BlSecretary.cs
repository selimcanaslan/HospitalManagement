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
        public bool AddSecretary(string tc_no, string name, string surname, string mail, string phone_number, string address)
        {
            return _dalSecretary.AddSecretary(tc_no, name, surname, mail, phone_number, address);
        }
        public DataTable fetchAllSecretary()
        {
            return _dalSecretary.fetchAllSecretary();
        }
        public DataTable fetchSecretaryByGivenName(string name)
        {
            return _dalSecretary.fetchSecretaryByGivenName(name);
        }
        public DataTable fetchSecretaryByGivenTcNo(string tcNo)
        {
            return _dalSecretary.fetchSecretaryByGivenTcNo(tcNo);
        }
        public bool updateSecretary(string name, string surname, string tcNo, string mail, string phoneNumber, string address, int id)
        {
            return _dalSecretary.updateSecretary(name, surname, tcNo, mail, phoneNumber, address, id);
        }
        public bool deleteSecretary(string phone_number)
        {
            return _dalSecretary.deleteSecretary(phone_number);
        }
        public string lowercasedAndTrimmedNameSurname(string tcNo)
        {
            return _dalSecretary.lowercasedAndTrimmedNameSurname(tcNo);
        }
    }
}
