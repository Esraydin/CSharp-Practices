using System;
namespace Haz_rMetodlar{
    class Program{
        static void Main(string[] args){
            string degisken = "dersimiz c# ,hosgeldiniz.";
            string degisken2 = "Dersimiz CSharp";

            //length;
            Console.WriteLine(degisken.Length);

            //ToUpper , ToLower;
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //concat(birleştirir).
            Console.WriteLine(String.Concat(degisken,"Merhaba!"));

            //compare,compareTo
            Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            //Contains içinde var mı diye bakıyor
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("hosgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));


            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));//bulursa bulunduğu indexi döndürüyor
            Console.WriteLine(degisken.IndexOf("Esra"));//bulamazsa -1 döndürüyor.
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba!"));//0.indexten baslayarak stringin basına bunu ekler
            
            //PadLeft,PadRight;
            Console.WriteLine(degisken + degisken2.PadLeft(30)); //karakter sayısı 30değilse 30'a tamamlayacak kadar boşluk ekler
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

            //Remove
            
            Console.WriteLine(degisken.Remove(10));//10.indexten baslayarak sonuna kadar siler.
            Console.WriteLine(degisken.Remove(5,3));//5.indexten baslayarak 3 karakter s,lmek.
            Console.WriteLine(degisken.Remove(0,1));//0ıncı indexten baslayarak 1 karakter(en baştaki index)

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));//CSharp 'ı C# ile değiştirç
            Console.WriteLine(degisken.Replace(" ","*"));
             
             //Split(çok kullanılır)
             Console.WriteLine(degisken.Split(' ')[1]);

             //Substring
             Console.WriteLine(degisken.Substring(4));//4.indexten baslayarak sonuna kadar yazar.
             Console.WriteLine(degisken2.Substring(4,6));//4.indexten baslayarak 6 karakter getirir.


    




        }
    }
}