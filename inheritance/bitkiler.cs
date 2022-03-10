using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class bitkiler:canlılar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("bitkiler fotosentez yapar");
        }
    }
    public class tohumluBitkier:bitkiler
    {
        public tohumluBitkier()
        {
            base.Fotosentez();
            base.bosaltım();
            base.beslenme();
            base.solunum();
            
        }
        public void tohhumlacogalma()
        {
            
            Console.WriteLine("tohumlu bitkiler tohumla cogalır");
        }

    }

    public class TohumsuzBitkiler:bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
            base.bosaltım();
            base.beslenme();
            base.solunum();
        }
        public void tohumsuzcoğalma()
        {
            
            Console.WriteLine( "tohumsuz bitkiler sporla coğalır");
        }
    }
}
