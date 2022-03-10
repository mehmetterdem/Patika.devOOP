using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_arayüz
{
    class FileLogger : ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("dosyaya log yazar");
        }
    }
}
