using inheritance;
using System;

namespace polymorphisim
{
    class Program
    {
        static void Main(string[] args)
        {
            tohumluBitkier tohumluBitki = new tohumluBitkier();

            tohumluBitki.tohhumlacogalma();
            Console.WriteLine("*******************");
            kuslar Martı = new kuslar();

            Martı.ucmak();
            Console.WriteLine("************");
            TohumsuzBitkiler tohumsuzBitki = new TohumsuzBitkiler();
            tohumsuzBitki.tohumsuzcoğalma();
        }
    }
}
