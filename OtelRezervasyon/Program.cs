using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Otel MamoOtel= new Otel();

            Oda oda1 = new Oda(101, 4, 6, 2500, OdaTipi.CiftKisilik);
            Oda oda2 = new Oda(101, 5, 4, 2000, OdaTipi.Suit);
            Müsteri müsteri1 = new Müsteri(132, "Ömer Faruk Kuş ", "535353553", "omer@gmial.com");
            Müsteri müsteri2 = new Müsteri(111, "vahit Kuş ", "356356275", "Vahitkus@gmial.com");
           

            DateTime giris = new DateTime(2026, 9, 10, 14, 0, 0);
            DateTime cikis = new DateTime(2026, 9, 15, 11, 0, 0);

            DateTime giris1 = new DateTime(2026, 9, 15, 14, 0, 0);
            DateTime cikis2 = new DateTime(2026, 9, 20, 11, 0, 0);


            Rezervasyon rezervasyon1 = new Rezervasyon(12, oda1, müsteri2,giris,cikis );
            Rezervasyon rezervasyon2= new Rezervasyon(13,oda2,müsteri1,giris1,cikis2 );

            MamoOtel.RezervasyonYap(rezervasyon2 );
            MamoOtel.RezervasyonYap(rezervasyon1 );
            rezervasyon1.İptalEt();
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("=== MAMO OTEL ===");
                Console.WriteLine("1 - Odaları listele");
                Console.WriteLine("2 - Rezervasyonları listele");
                Console.WriteLine("3 - Rezervasyon yap");
                Console.WriteLine("4 - Rezervasyon iptal et");
                Console.WriteLine("0 - Çıkış");

                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        MamoOtel.OdalariListele();
                        break;

                    case "2":
                        MamoOtel.RezervasyonlarıGöster();
                        break;

                    case "0":
                        devam = false;
                        Console.WriteLine("Program kapatılıyor...");
                        break;

                    case "3":

                        Console.Write("Müşteri ID: ");
                        int musteriId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Ad Soyad: ");
                        string ad = Console.ReadLine();

                        Console.Write("Telefon: ");
                        string telefon = Console.ReadLine();

                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        Müsteri yeniMusteri = new Müsteri(
                            musteriId,
                            ad,
                            telefon,
                            email
                        );
                        Console.Write("Oda numarası: ");
                        int kapiNo = Convert.ToInt32(Console.ReadLine());

                        Oda secilenOda = MamoOtel.OdaBul(kapiNo);
                        Console.Write("Giriş tarihi (örn: 10.09.2026): ");
                        DateTime girisTarihi = DateTime.Parse(Console.ReadLine());

                        Console.Write("Çıkış tarihi (örn: 15.09.2026): ");
                        DateTime cikisTarihi = DateTime.Parse(Console.ReadLine());
                        Console.Write("Rezervasyon ID: ");
                        int rezervasyonId = Convert.ToInt32(Console.ReadLine());

                        Rezervasyon yeniRezervasyon = new Rezervasyon(
                            rezervasyonId,
                            secilenOda,
                            yeniMusteri,
                            girisTarihi,
                            cikisTarihi
                        );
                        MamoOtel.RezervasyonYap(yeniRezervasyon);
                        break;
                   
                    case "4":

                        Console.Write("İptal edilecek rezervasyon ID: ");
                        int iptalId = Convert.ToInt32(Console.ReadLine());

                        Rezervasyon iptalEdilecek =
                            MamoOtel.RezervasyonBul(iptalId);

                        iptalEdilecek.İptalEt();
                        Console.WriteLine("Rezervasyon iptal edildi.");
                        break;


                    default:
                        Console.WriteLine("Geçersiz seçim.");
                        break;
                }
            }



            Console.ReadLine();
        }
    }
}
