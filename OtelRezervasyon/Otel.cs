using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    internal class Otel
    {
        public List<Oda> Odalar { get; private set; }
        = new List<Oda>();
        public List<Rezervasyon> Rezervasyonlar { get; private set; }
      = new List<Rezervasyon>();

        public void OdaEkle(Oda oda)
        {
            if (oda == null)
            {
                throw new ArgumentNullException("Oda boş bırakılamaz.");
            }

            foreach (Oda mevcutOda in Odalar)
            {
                if (mevcutOda.KapiNo == oda.KapiNo)
                {
                    throw new InvalidOperationException(
                        "Bu kapı numarasına sahip oda zaten mevcut."
                    );
                }
            }

            Odalar.Add(oda);
        }
        public Oda OdaBul(int kapiNo)
        {
            foreach (Oda oda in Odalar)
            {
                if (oda.KapiNo == kapiNo)
                {
                    return oda;
                }
            }

            throw new InvalidOperationException(
                "Bu kapı numarasına sahip oda bulunamadı."
            );
        }
        public Rezervasyon RezervasyonBul(int rezervasyonId)
        {
            foreach (Rezervasyon rezervasyon in Rezervasyonlar)
            {
                if (rezervasyon.RezervasyonID == rezervasyonId)
                {
                    return rezervasyon;
                }
            }

            throw new InvalidOperationException(
                "Bu ID'ye sahip rezervasyon bulunamadı."
            );
        }
        public void RezervasyonYap(Rezervasyon yeniRezervasyon)
        {
            if (yeniRezervasyon == null)
            {
                throw new ArgumentNullException("Rezervasyon boş olamaz.");
            }

            if (!yeniRezervasyon.Oda.KullanımaAcikMi)
            {
                throw new InvalidOperationException("Bu oda kullanıma açık değil.");
            }
            foreach (Rezervasyon mevcutRezervasyon in Rezervasyonlar)
            {
                if (mevcutRezervasyon.Oda.KapiNo == yeniRezervasyon.Oda.KapiNo)
                {
                    if (mevcutRezervasyon.Durum == RezervasyonDurumu.Aktif)
                    {
                        if (yeniRezervasyon.GirisTarihi < mevcutRezervasyon.CikisTarihi &&
                            yeniRezervasyon.CikisTarihi > mevcutRezervasyon.GirisTarihi)
                        {
                            throw new InvalidOperationException(
                                "Bu oda seçilen tarihler arasında dolu."
                            );
                        }
                    }
                }
            }

            Rezervasyonlar.Add(yeniRezervasyon);
            Console.WriteLine("rezervasyonunuz eklendii");
        }
        public void OdalariListele()
        {
            foreach(Oda oda in Odalar)
            {
                oda.BilgiGöster();
            }
        }
        public void RezervasyonlarıGöster()
        {
            foreach(Rezervasyon rezervasyon in Rezervasyonlar)
            {
                rezervasyon.BilgileriGöster();
            }
        }



    }
}
