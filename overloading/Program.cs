using System;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler
            string sayi = "999";
            int outSayi;

            bool sonuc = int.TryParse(sayi, out outSayi);
            if (sonuc)
            {
                Console.WriteLine("başarılı");
                Console.WriteLine(outSayi);
            }

            else
            {
                Console.WriteLine("başarısız");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(2, 3, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);


            //Metot Overloading(Aşırı yükleme)
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Esra","aydın");

            //metot imzası: metotAdi + parametre sayisi + parametre
        }

    }
    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;

        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        { //metodu overload etmiş oluruz.aynı metotta hem string hem int tipinde veri alıyor.
            Console.WriteLine(veri);
        }

        //aldığı iki veriyi birleştirip ekrana yazdıran metot:
        public void EkranaYazdir(string veri1, string veri2){
            Console.WriteLine(veri1 + veri2);
        }
    }

}
