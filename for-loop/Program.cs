using System;

namespace for_loop
{

    class Program
    {
        static void Main(string[] args)
        {
             //ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
             Console.Write("Bir sayı giriniz.");
             int sayac = int.Parse(Console.ReadLine()); //ReadLine() ekrandan string okur,bu yüzden int.Parse() fonksiyonu kullanırız.
             for(int i=1;i<=sayac;i++){
                if(i%2 == 1){
                    Console.WriteLine(i);
                 }
             }

            //1 ile 1000 arasındaki tek ve çift sayıların toplamını ayrı ayrı bulan program.
             int tekToplam = 0;
             int ciftToplam = 0;
             for(int i = 0; i<= 1000; i++){
                if(i%2 == 1){
                     tekToplam+=i;
                 }
                 else{
                    ciftToplam+=i;
                 }

             }
             Console.WriteLine("Tek sayıların toplamı: "+ tekToplam);
             Console.WriteLine("Çift sayıların toplamı: "+ ciftToplam);

            //break,continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
             for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }


        }


    }
}