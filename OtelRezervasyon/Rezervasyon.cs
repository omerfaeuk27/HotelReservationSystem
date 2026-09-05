using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    internal class Rezervasyon
    {
        private int _RezervasyonID;
        private decimal _ToplamÜcret;
        public int RezervasyonID {
            get { return _RezervasyonID; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Rezervasyon Id  0'dan büyük olmalıdır.");
                }
                _RezervasyonID = value;
            }
        }
        public RezervasyonDurumu Durum { get; private set; }
        public decimal ToplamUcret { get;private set; }
        public Oda Oda { get; private set; }
        public Müsteri Müsteri { get;private set; }
        public DateTime GirisTarihi { get;private set; }
        public DateTime CikisTarihi { get; private set; }
        public Rezervasyon(
                int rezervasyonID,
                Oda oda,
                Müsteri musteri,
                DateTime girisTarihi,
                DateTime cikisTarihi)
        {
            if (cikisTarihi <= girisTarihi)
            {
                throw new ArgumentException(
                    "Çıkış tarihi giriş tarihinden sonra olmalıdır."
                );
            }

            RezervasyonID = rezervasyonID;
            Oda = oda;
            Müsteri = musteri;
            GirisTarihi = girisTarihi;
            CikisTarihi = cikisTarihi;

            Durum = RezervasyonDurumu.Aktif;

            TimeSpan kalmaSuresi = CikisTarihi - GirisTarihi;
            int geceSayisi = kalmaSuresi.Days;

            ToplamUcret = geceSayisi * Oda.GecelikFiyat;
        }
        public void İptalEt()
        {
            if (Durum != RezervasyonDurumu.Aktif)
            {
                throw new ArgumentException("Sadece Aktif olan durumlarda iptal edilebilir.");

            }
            Durum = RezervasyonDurumu.IptalEdildi;
        }
        public void BilgileriGöster()
        {
            Console.WriteLine("Rezervasyon ID: "+RezervasyonID);
            Console.WriteLine("Rezervasyonun ait olduğu oda: "+Oda);
            Console.WriteLine("Rezervasyonun ait olduğu müşteri: "+Müsteri);
            Console.WriteLine("Toplam Ücret: "+ToplamUcret);
            Console.WriteLine("Rezervasyonun durumu: "+Durum);
            Console.WriteLine("Giriş tarihi: "+GirisTarihi);
            Console.WriteLine("Çıkış tarihi: "+CikisTarihi);

        }
    }
}
