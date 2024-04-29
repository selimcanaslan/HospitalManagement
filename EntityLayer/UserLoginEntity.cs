using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class UserLoginEntity
    {
        private int _id { get; set; }
        private string _kullaniciAd { get; set; }
        private string _kullaniciSifre { get; set; }
        private string _ad { get; set; }
        private string _soyad { get; set; }
        private string _tcno { get; set; }
        private string _mail { get; set; }
        private string _address { get; set; }
        private string _phoneNumber { get; set; }
        private string _authType { get; set; }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string KullaniciAd
        {
            get { return _kullaniciAd; }
            set { _kullaniciAd = value; }
        }

        public string KullaniciSifre
        {
            get { return _kullaniciSifre; }
            set { _kullaniciSifre = value; }
        }

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }
        public string Tcno
        {
            get { return _tcno; }
            set { _tcno = value; }
        }
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public string AuthType
        {
            get { return _authType; }
            set { _authType = value; }
        }
    }
}
