using System;

class Program{
static void Main(string[] args){
    Console.WriteLine(DateTime.Now);//günün tarihini getirir.
    Console.WriteLine(DateTime.Now.Date);//gün ay yıl
    Console.WriteLine(DateTime.Now.Day);//gün
    Console.WriteLine(DateTime.Now.Month);//ay
    Console.WriteLine(DateTime.Now.Year);//yıl
    Console.WriteLine(DateTime.Now.Hour);//saat
    Console.WriteLine(DateTime.Now.Minute);//dakika
    Console.WriteLine(DateTime.Now.Second);//saniye

    Console.WriteLine(DateTime.Now.DayOfWeek);//haftanın gününü string şekilde.
    Console.WriteLine(DateTime.Now.DayOfYear);//içinde bulunduğumuz yılın kaçıncı yılı.

    Console.WriteLine(DateTime.Now.ToLongDateString());
    Console.WriteLine(DateTime.Now.ToShortTimeString());
    Console.WriteLine(DateTime.Now.ToLongTimeString());

    Console.WriteLine(DateTime.Now.AddDays(2));
    Console.WriteLine(DateTime.Now.AddHours(3));
    Console.WriteLine(DateTime.Now.AddSeconds(30));
    Console.WriteLine(DateTime.Now.AddYears(10));

    // Datetime format
    Console.WriteLine(DateTime.Now.ToString("dd"));//29
    Console.WriteLine(DateTime.Now.ToString("ddd"));
    Console.WriteLine(DateTime.Now.ToString("dddd"));
   

   Console.WriteLine(DateTime.Now.ToString("MM"));
   Console.WriteLine(DateTime.Now.ToString("MMMM"));
   Console.WriteLine(DateTime.Now.ToString("MMMMM"));

   Console.WriteLine(DateTime.Now.ToString("yy"));//22
   Console.WriteLine(DateTime.Now.ToString("yyyy"));//2022

   //Math Kütüphanesi
   Console.WriteLine(Math.Abs(-1));//- değer verildiğinde +değere çevirir.
   Console.WriteLine(Math.Sin(10)); //Sinüs hesabı
   Console.WriteLine(Math.Cos(90)); //cos
   Console.WriteLine(Math.Tan(10));//tan
   Console.WriteLine(Math.Ceiling(22.3));//double ve float gibi değişkenlerde karar vermeyi sağlamak için.22.3'ten büyük en küçük tamsayıyı getirecek.
   Console.WriteLine(Math.Round(22.3));//hangisine daha yakınsa,22ye yakın 22 getirecek.
   Console.WriteLine(Math.Floor(22.7));//22.7'den kücük tam sayı.

   Console.WriteLine(Math.Max(2,6));
   Console.WriteLine(Math.Min(2,6));
   Console.WriteLine(Math.Pow(3,4));//üs alma 
   Console.WriteLine(Math.Sqrt(9));//karekök alır
   Console.WriteLine(Math.Log(9)); //9 un e tabanındaki logaritmik karşılığı
   Console.WriteLine(Math.Exp(3));//e üzeri 3'ü verir.
   Console.WriteLine(Math.Log(10));

}
}