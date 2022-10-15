using System;

namespace RecursiveFunction{
    class Program{
        static void Main(string[] args){
            //rekürsif-özyinelemeli fonksiyonlar
            //3^4
           int result = 1;
            for(int i = 1 ; i< 5 ; i++){
            result = result*3;
            }

            Console.WriteLine(result);

            Islemler islemler = new(); // bu şekilde de nesne oluşturulur.
            Console.WriteLine(islemler.Expo(3,4)); //buna erişebilmemiz için ıslemler classından bir instance oluşturmamız gerekir.

            //Extension Metotlar
            
            string ifade ="Esra Aydın";//verilen cümle üzerinde boşluk olup olmadığını dönen bir extension metot.
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if(sonuc){
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            //int diziyi sıralayan extension metot
            int[] dizi = {9,3,6,2,1,5,0};
            dizi.SortArray();
            dizi.EkranaYazdir();
            
            int sayi = 5;
            Console.WriteLine(sayi.IsEven());

            Console.WriteLine(ifade.GetFirsCharacter());
        }
    }

    public class Islemler{
        public int Expo(int sayi,int üs)
        {
            if(üs<2)
               return sayi;
            return Expo(sayi,üs-1)*sayi;//kendi kendini çağıracak.
        }
        //Expo(3,4)
        //Expo(3,3) * 3 ;
        //Expo(3,2) * 3 * 3;
        //Expo(3,1) * 3 * 3 * 3;
        //3 * 3 * 3 * 3 = 3^4;
    }
    public static class Extension{ //Extension classlar ve metotlar static olmalı.nesnesi olmadan erişebilmemiz için.

       public static bool CheckSpaces(this string param) //this ifadesi eklendiğinde extension olur.
       {
         return param.Contains(" ");//string kütüphanesinin bir metodu.
       }
      // boşluk ifadesini bir karakterle değiştiren fonksiyon
      public static string RemoveWhiteSpaces(this string param){
        string[] dizi = param.Split(" "); // bu stringi boşluklara göre ayırıp bir diziye atıyacak.
        return string.Join( "",dizi); 
      }

      //verilmiş olan stringi büyük harflere çeviren program

      public static string MakeUpperCase(this string param){
        return param.ToUpper();
      }
       public static string MakeLowerCase(this string param){
        return param.ToLower();
      }
      public static int[] SortArray(this int[] param)
      {
        Array.Sort(param);
        return param;
      }
      public static void EkranaYazdir(this int[] param){
        foreach(var item in param)
        Console.WriteLine(item);

        
      }
      public static bool IsEven(this int param){//verilen sayı tek mi çift mi
         return param%2 == 0;
      }
      //verilen stringin ilk karakterini dönen fonk.
      public static string GetFirsCharacter(this string param){
        return param.Substring(0,1); //1.indexten başlayarak kaç karakter gelmesi için.
      }
    }
}
