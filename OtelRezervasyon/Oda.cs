using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    internal class Oda
    {
        private int _KapiNo;
        private int _KatNo;
        private int _Kapasite;
        private decimal _fiyat;
        public int KapiNo {
            get { return _KapiNo; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Kapı numarası 0'dan büyük olmalıdır.");
                }
                _KapiNo = value;
            }

        
        }
        public int KatNo { 
            get { return _KatNo; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Kat numarası 0'dan büyük olmalıdır.");
                }
                _KatNo = value;
            }
        
        }
        public int Kapasite {
            get { return _Kapasite; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Kapasite  0'dan büyük olmalıdır.");
                }
                _Kapasite = value;
            }
        }
        public bool KullanımaAcikMi { get; private set; } = true;
        public decimal GecelikFiyat {
            get { return _fiyat; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Fiyat 0'dan büyük olmalıdır.");
                }
                _fiyat = value;
            }
        }
        public OdaTipi Tip { get;  private set; }


        public Oda(int KapıNo,int KatNo,int Kapasite,decimal GecelikFiyat,OdaTipi Tip)
        {
            this.KapiNo = KapıNo;
            this.KatNo = KatNo;
            this.Kapasite=Kapasite;
            this.GecelikFiyat = GecelikFiyat;
            this.Tip=Tip;
            
        }
        public override string ToString()
        {
            return $"Oda No: {KapiNo} - Tip: {Tip} - Fiyat: {GecelikFiyat} TL";
        }
        public void BilgiGöster()
        {
            Console.WriteLine("Oda kapı No: "+KapiNo);
            Console.WriteLine("Oda kat No: "+KatNo);
            Console.WriteLine("Oda Kapasite:"+Kapasite);
            Console.WriteLine("Oda Gecelik fiyat: "+GecelikFiyat);
            Console.WriteLine("Oda kullanıma Açık mı : "+KullanımaAcikMi);
            Console.WriteLine("Oda Tipi: "+Tip);
        }



    }

}
