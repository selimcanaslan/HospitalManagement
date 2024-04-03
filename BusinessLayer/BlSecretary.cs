using DataAccessLayer;
using System;
using System.Collections.Generic;
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
        public bool AddSecretary(string name, string surname, string mail, string phone_number, string address)
        {
            return _dalSecretary.AddSecretary(name, surname, mail, phone_number, address);
        }
    }
}
