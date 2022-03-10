using System;

namespace interfaceÖrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            focus focus = new focus();
            Console.WriteLine(focus.HangiMarka());
            Console.WriteLine(focus.KacTekerlek());
            Console.WriteLine(focus.StandartRengi());
            Console.WriteLine("******************");
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarka());
            Console.WriteLine(civic.KacTekerlek());
            Console.WriteLine(civic.StandartRengi());
            Console.WriteLine("**************");
            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarka());
            Console.WriteLine(corolla.KacTekerlek());
            Console.WriteLine(corolla.StandartRengi());
        }
    }
}
