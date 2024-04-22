using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class UserLoginEntity
    {
        private string _kullaniciAd { get; set; }
        private string _kullaniciSifre { get; set; }
        private string _AuthType { get; set; }

        public string kullaniciAd
        {
            get
            {
                return _kullaniciAd;
            }
            set
            {
                _kullaniciAd = value;
            }
        }
        public string kullaniciSifre
        {
            get
            {
                return _kullaniciSifre;
            }
            set
            {
                _kullaniciSifre = value;
            }
        }
        public string AuthType
        {
            get
            {
                return _AuthType;
            }
            set
            {
                _AuthType = value;
            }
        }
    }
}
