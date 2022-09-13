//Aynı  tip değişkenlerin bir arada tutulmasına dizi denir.
//diziler 0.indexten başlar.


using System;

namespace diziler1{
   class Program
    {
        public static void Main(string[] args)
        {
            string[] renkler = new string[5]; //5 elemanlı bir dizi tanımlandı.

            string[] hayvanlar = {"kedi","köpek","kuş","maymun"}; //eleman ataması direkt de yapılabilir. 4 elemanlı bir dizi. boyutu 4.

            int[] dizi;
            dizi = new int[5]; 

            //dizilere değer atama ve erişim
            renkler[0] ="Mavi"; //renkler dizisinin ilk elemanına atama yaptık.
            Console.WriteLine(hayvanlar[1]); //hayvanlar dizisinin 1.elemanına erişim sağlandı.
            dizi[3] = 10; //dizinin 3. elemanına 10 değeri atandı.

            Console.WriteLine(dizi[3]);
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[0]);


            //Döngülerle dizi kullanılması.
            //Klavyeden girilen n tane sayının ortalamasını alan program.

            Console.Write("Dizinin eleman sayısını girin: ");
            int diziU = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziU]; //konsoldan girilen sayıya göre bir dizi tanımlandı.
           
            for(int i=0;i<diziU;i++)//<= değil çünkü diziler 0.indexten başlar
            { 
              Console.Write("Lütfen {0}.sayıyı giriniz: ",i+1);
              sayiDizisi[i] = int.Parse(Console.ReadLine()); //her for döngüsünde girilen sayıyı diziye atayacak.

            }
            int toplam =0;
             foreach(var sayi in sayiDizisi){
                   toplam += sayi;
                  
             }
              Console.WriteLine("Dizinin ortalaması: "+toplam/diziU);

        } 
    }
}
