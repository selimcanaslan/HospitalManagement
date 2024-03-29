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
    }
}
