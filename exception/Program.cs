﻿
using System;

namespace exception
{
    class Program
    {
       static void Main(string[] args)
        {
            //try bloğu içerisinde hataya neden olacak olan kod yazılır.
            try
            {
                Console.WriteLine("Bir sayi giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine()); //console'dan girilen sayıyı integer'e çevirdik.
                Console.WriteLine("girmiş olduğunuz sayı: " + sayi);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString()); //hata fırlatılır.
            }
            finally
            {
                //bir kod bloğu hata alsın almasın çalıştırılmak istenilen blok yazılır.
                Console.Write("işlem tamamlandı.");
            }
            
        }

    }
}
