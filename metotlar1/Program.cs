using System;

namespace metotlar1
{

    class Program
    {
        static void Main(string[] args)
        {
            // erişim belirteci geri dönüş tipi metod adı(parametreListesi/argüman)
            //{
            //komutlar;
            // return;

            //}
            //iki sayıyı toplayan fonksiyonu yazalım.
            int a = 2;
            int b = 3;


            Console.WriteLine(a + b);
            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

             Metotlar ornek = new Metotlar(); //instance yani örnek oluşturuldu.Şu an erişilemeyecek,erişim belirleyiciler default olarak privatetır.
             ornek.EkranaYazdir(Convert.ToString(sonuc));
             int sonuc2 = ornek.ArttırVeTopla(ref a,ref b); //a ile b nin değerleri değil de referansları,yani bellekteki karşılıkları verilir.
             ornek.EkranaYazdir(Convert.ToString(sonuc2));
             ornek.EkranaYazdir(Convert.ToString(a+b));


        }
        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar{ //yeni class tanımlandı.
         public void EkranaYazdir(String veri){ //erişim belirleyiciler default olarak privatetır. 
            Console.WriteLine(veri); //geriye bir şey dönmüyor,sadece yazdırma işlemi yapıyor,dönüş tipi void olmalı.

         }
         public int ArttırVeTopla(ref int deger1 , ref int deger2){ 
            deger1 += 1;
            deger2 += 1;
            return deger1+deger2;
         }
    }
}
