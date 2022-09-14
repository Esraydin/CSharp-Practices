using System;

namespace ArrayS_n_f_{
    class Program
    {
         static void Main(string[] args)
        {
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            Console.WriteLine("***** Sırasız dizi *****");
            foreach(var sayi in sayiDizisi) //dizinin elemanlarına erişim sağlandı.
                Console.WriteLine(sayi); 

            Console.WriteLine("*****Sıralı Dizi*****");
            Array.Sort(sayiDizisi);  //sort ile sıralanacak.
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //clear-verdiğimiz dizi indexinde verdiğimiz eleman kadar diziyi sıfırlar.
            Console.WriteLine("******Array Clear*****");

            Array.Clear(sayiDizisi,2,2); //2.indexten başlayarak 2 elemana 0 değeri atayacak.
            foreach(var sayi in sayiDizisi)
               Console.WriteLine(sayi);

            //Reverse-tersine çevirme işlemi.Verilen diziyi ortadan itibaren yer değiştirir.
            Console.WriteLine("******Array Reverse*****");
            Array.Reverse(sayiDizisi);
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //indexOf -verdiğimiz dizinin verdiğimiz elemanınn indexini döner.
             Console.WriteLine("******IndexOf*****");
             Console.WriteLine(Array.IndexOf(sayiDizisi,23)); 
             
             //Resize - Dizileri yeniden boyutlandırmak için kullanılır.
             Console.WriteLine("***Array resize***");
             Array.Resize<int>(ref sayiDizisi,9);
             sayiDizisi[8] = 99;

             foreach(var sayi in sayiDizisi)
                 Console.WriteLine(sayi);

            
        }
    }
}