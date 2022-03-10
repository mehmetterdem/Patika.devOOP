using System;

namespace enumlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(günler.pazartesi);
            Console.WriteLine((int)günler.pazartesi);

            int sıcaklık = 32;
            if (sıcaklık<=(int)havaDurumu.normal)
            {
                Console.WriteLine("dısarıya cıkmak ıcın havanın ısınmasını bekleyelim");

            }
            else if (sıcaklık>=(int)havaDurumu.sıcak)
            {
                Console.WriteLine("dısarıya cıkmak ıcın sıcak bir gun");
            }
            else if (sıcaklık>(int)havaDurumu.normal&&sıcaklık< (int)havaDurumu.coksıcak)
            {
                Console.WriteLine("dısarıya cıkmak için tam zamanı");
            }



        }
    }

    enum günler
    {
        pazartesi,
        salı,
        carsamba,
        persembe,
        cuma,
        cumartesi,
        pazar

    }
    enum havaDurumu
    {
        soguk=5,
        normal=20,
        sıcak=25,
        coksıcak=30
    }


}

