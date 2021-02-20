using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 684259;
            musteri1.Who = "Mehmet Demirkol";
            musteri1.Adress = "Batman";



            Musteri musteri2 = new Musteri();
            musteri2.Id = 598743;
            musteri2.Who = "Berkin Kaysay";
            musteri2.Adress = "Trakya";

            Musteri musteri3 = new Musteri();
            musteri3.Id =123654;
            musteri3.Who = "Kerem Kaykan";
            musteri3.Adress = "Kocaeli";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 159753;
            musteri4.Who = "Furkan Yılmaz";
            musteri4.Adress = "İzmir";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("---Müşteri Bilgileri---");
                Console.WriteLine("Müşteri Id Numarası: " + musteri.Id);
                Console.WriteLine("Müşteri Bilgisi: " + musteri.Who);
                Console.WriteLine("Musteri Adresi: " + musteri.Adress);
            }

            MusteriManager musteriEkle = new MusteriManager();
            musteriEkle.addMusteri(musteri1);
            musteriEkle.addMusteri(musteri2);

            MusteriManager musteriSil = new MusteriManager();
            musteriSil.deleteMusteri(musteri3);
            musteriSil.deleteMusteri(musteri4);
        }
    }
}
