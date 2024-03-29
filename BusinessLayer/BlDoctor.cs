using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BlDoctor
    {
        private DALDoktor _dalDoctor;
        public BlDoctor()
        {
            _dalDoctor = new DALDoktor();
        }
        public void AddDoctor(string name, string surname, string section, string mail, string phone_number, string address)
        {
            _dalDoctor.AddDoctor(name, surname, section, mail, phone_number, address);
        }
    }
}
