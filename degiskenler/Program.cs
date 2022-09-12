using System ;

namespace degiskenler{
     class Program
    {
        public static void Main(string[] args)
        {
          int deger=2;
          String değişken=null; //büyük küçük harfe duyarlıdır.
          String Değişken=null; //Değişken isimleri rakamla başlayamaz.
         Console.WriteLine(deger);
         DateTime dt = DateTime.Now; // tarih belirtmek için,birçok işlem yapılabilir.
         object o1= "a";
         object o2= 2;
         object o3= 4.3; //object her türden veriyi alabilir.Tüm değişken tipleri aslında objecttir. Üst tip olarak düşünülebilir.

         // String ifadeler

         String s1=string.Empty;
         s1="Esra Aydın";
         //Değişken dönüşümleri
         string str20="20";
         int int20=20;

         string yeniDeger= str20+int20.ToString();
         Console.WriteLine(yeniDeger);

        }
    }
}
