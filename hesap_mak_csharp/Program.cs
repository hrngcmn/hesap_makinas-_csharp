using System;
using System.Data;
namespace uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi, sayi1;
            double i, k, a;
            string sec;
            a = 0;
            i = 0;
            k = 0;
            while (k < 2)
            //k değeri rastgele seçilmiştir.Önemli olan burada sürekli döngüye sokmaktır
            {
                Console.Write("sayi giriniz: ");
                sayi = Convert.ToDouble(Console.ReadLine());
                k++; // k bu aşamadan sonra 1 olacaktır.
                i = i + sayi; // ilk girilen sayinin değeriniz i ye atadım
                Console.WriteLine(i); // i yi yazdırdım
                if (k == 1)
                // Yukarıdakiler 1 defa çalıştıktan sonra k=1 olmuştu if koşulu yukarıdaki kodların 1 kere çalışmasını sağladım.
                {
                    while (a < 2) // a değeri rastgele seçilmiştir.DÖNGÜ İÇİNDE DÖNGÜ
                    {
                        Console.Write("Seçilen işlem =  "); // Kullanıcıya işlem seçimi yaptırdım.
                        sec = Console.ReadLine(); // seçimi okuttum.
                        Console.Write("sayi gir : ");  //Kullanıcıdan yeni sayı girişi istendi
                        sayi1 = Convert.ToDouble(Console.ReadLine()); // Girilen sayı string olduğundan Double dönüşümü yaptım
                        if (sec == "+") // Eğer + seçilmiş ise
                        {
                            i = i + sayi1;  // atanmış i değeri ile yeni sayı toplanır
                            a = 1; // Bu sayede sürekli olarak ikinci oluşturulan döngüde kalması sağlanır.
                        }
                        if (sec == "-")
                        {
                            i = i - sayi1; // atanmış i değeri ile yeni sayı çıkarılır
                            a = 1; // Bu sayede sürekli olarak ikinci oluşturulan döngüde kalması sağlanır.
                        }
                        if (sec == "*")
                        {
                            i = i * sayi1;  // atanmış i değeri ile yeni sayı çarpılır
                            a = 1; // Bu sayede sürekli olarak ikinci oluşturulan döngüde kalması sağlanır.
                        }
                        if (sec == "/")
                        {
                            i = i / sayi1; // atanmış i değeri ile yeni sayı bölünür
                            a = 1; // Bu sayede sürekli olarak ikinci oluşturulan döngüde kalması sağlanır.
                        }
                        if (sec != "+" && sec != "-" && sec != "*" && sec != "/")
                        {
                            Console.WriteLine("yanlış işlemi seçtiniz bi daha deneyiniz");
                        }
                        Console.WriteLine(" = " + i);
                    }
                }
            }
        }
    }
}
