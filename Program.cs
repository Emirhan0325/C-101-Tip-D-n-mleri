using System;

namespace degisken
{
    class program
    {
        static void Main(string[] args)
        {
            // İmplicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("***** İmplicit Conversion *****");

            byte a = 5;
            sbyte b = 10;
            short c = 20;

            int d = a+b+c;
            Console.WriteLine("d : " + d);

            long h = d;
            Console.WriteLine("h : " + h);

            float i = h;
            Console.WriteLine("i : " + i);

            string e = "Emirhan";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g : " + g);

            // Explicit Conversion (Bilnçli Dönüşüm)

            Console.WriteLine("***** Explicit Conversion *****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y : " + y);

            int z = 100; 
            byte t = (byte)z;
            Console.WriteLine("t : " + t);

            float o = 10.44f;
            byte v = (byte)o;
            Console.WriteLine("v : " + v); 

            // *** ToString Methodu *** 
            Console.WriteLine("***** ToString Methodu *****");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy : " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz : " + zz);

            // System.Convert
            Console.WriteLine("***** System.Convert sınıfı *****");

            string s1 = "10" , s2 = "20";
            int sayi1 , sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + toplam);

            // Parse
            Console.WriteLine("***** Parse *****");

            ParseMethod();    




        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "20";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Int32.Parse(metin2);

            Console.WriteLine("rakam1 : " + metin1);
            Console.WriteLine("double : " + metin2);               
        }
    }
}       
