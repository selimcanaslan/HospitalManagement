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
        public BlSecretary()
        {
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
        public bool deleteSecretary(string tc_no)
        {
            return _dalSecretary.deleteSecretary(tc_no);
        }
        public string lowercasedAndTrimmedNameSurname(string tcNo)
        {
            return _dalSecretary.lowercasedAndTrimmedNameSurname(tcNo);
        }

        public bool AddDoctor(string tc_no, string name, string surname, string mail, string phone_number, string address, string section)
        {
            return _dalSecretary.AddDoctor(tc_no, name, surname, mail, phone_number, address, section);
        }
        public DataTable fetchDoctorByGivenTcNo(string tcNo)
        {
            return _dalSecretary.fetchDoctorByGivenTcNo(tcNo);
        }
        public bool updateDoctor(string name, string surname, string tcNo, string section, string mail, string phoneNumber, string address, int id)
        {
            return _dalSecretary.updateDoctor(name, surname, tcNo, section, mail, phoneNumber, address, id);
        }
        public DataTable fetchDoctorByGivenName(string name)
        {
            return _dalSecretary.fetchDoctorByGivenName(name);
        }
        public DataTable fetchAllDoctor()
        {
            return _dalSecretary.fetchAllDoctor();
        }
        public bool deleteDoctor(string tc_no)
        {
            return _dalSecretary.deleteDoctor(tc_no);
        }
    }
}
