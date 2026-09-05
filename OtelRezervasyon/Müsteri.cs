using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OtelRezervasyon
{
   
    internal class Müsteri
    {
        private int _MüsteriID;
        private string _Ad;
        private string _TelNo;
        private string _Email;
        public int MüsteriID {
            get { return _MüsteriID; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Müşteri Id  0'dan büyük olmalıdır.");
                }
                _MüsteriID = value;
            }
        }
        public override string ToString()
        {
            return $"ID: {MüsteriID} - Ad: {Ad} - Telefon: {TelNo}";
        }
        public string Ad
        {
            get { return _Ad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Müşteri ismi boş bırakılamaz.");
                }
                _Ad = value;
            }
        }
        

        public string TelNo
        {
            get { return _TelNo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Telefon numarası boş bırakılamaz.");
                }

                _TelNo = value;
            }
        }
        public string Email
        {
            get { return _Email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Müşteri e-mail i boş bırakılamaz.");
                }
                _Email = value;
            }
        }
        public Müsteri(int müsteriID,string ad,string telno,string email)
        {
            MüsteriID = müsteriID;
            Ad = ad;
            TelNo = telno;
            Email = email;


        }
    }
}
