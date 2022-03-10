using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_arayüz
{
    public class DatabaseLogger : ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("database e yazar");
        }
    }
}
