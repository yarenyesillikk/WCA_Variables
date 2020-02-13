using System;

namespace WCA_Variables
{
    class Program
    {
        static void Main(string[] args)
        {


            byte sayi1 = 56;

            sbyte sayi2 =12;

            short sayi3 = 134;

            ushort sayi4 = 123;

            int sayi5 = 324;

            uint sayi6 = 21432432;

            long sayi7 = 324234;

            ulong sayi8 = 23424;

            float sayi9 = 12.0F;

            double sayi10 = 12.0;

            decimal sayi11 = 12.0M;


            char karakter = 'A';
            string metin1 = "Bilge\n Adam\n Beşiktaş\n Yazılım\n Dersleri";
            string metin2 = "Bilge Adam Beşiktaş Yazılım Dersleri";
            string metin3 = "Bilge Adam Beşiktaş Yazılım Dersleri";
            string tekKarakter = "A";
            string bos = "";

            Console.WriteLine(metin1);
            Console.WriteLine(metin2);
            Console.WriteLine(metin3);



            string tabBosluk = "Bilge\tAdam";
            Console.WriteLine(tabBosluk);

            string metin4 = "Bilge Adam Beşiktaş  \"Yazılım\"  Dersleri";
            Console.WriteLine(metin4);

            bool sonuc = false;
            bool result = 10 > 2;

            Console.WriteLine(result);
            



            Console.ReadKey();


        }
    }
}
