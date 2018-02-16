using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprivata
{
    public class LoggableTest
    {
        public LoggableTest(IOutputLogger outputLogger)
        {
            this.OutputLogger = outputLogger;
        }

        public IOutputLogger OutputLogger { get; private set; }

    }
}
