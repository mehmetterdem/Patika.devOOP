using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_arayüz
{
    public class LogManager:ILogger
    {
        public ILogger _logger;

        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void writeLog()
        {
            _logger.writeLog();
        }
    }
}
