namespace while_foreach{
     class Program
    {
        public static void Main(string[] args)
        {
            
             //while 
             //1'den başlayarak consoledan girilen sayıya kadar ortalama hesaplayıp console'a yazdıran program.
             Console.WriteLine("Bir sayı giriniz.");
             int sayi = int.Parse(Console.ReadLine());
             int sayac = 1;
             int toplam = 0;
            while(sayac<=sayi)
            {
               toplam+= sayac;
               sayac++;
            }
            Console.WriteLine(toplam/sayi);

            //A'dan Z'ye tüm harfleri console'a yazdır.
            char character = 'a';

            while(character < 'z')
            {
               Console.Write(character);
               character ++;
            }

            //foreach döngüsü 
             Console.WriteLine("***foreach***");
             string[] arabalar = {"BMW" ,"Ford", "Toyota", "Nissan"} //dizi tanımlaması.

             foreach (var araba in arabalar) //arabalar dizisinin her bir elemanı araba(item).
             {
              Console.WriteLine(araba) ; 
             }
        }
    }
}
