using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprivata
{
    /// <summary>
    ///  Normall use something like log4net or nlog, but for htis
    ///  small thing just write to a text box.
    /// </summary>
    public interface IOutputLogger
    {
        void WriteMessage(string message);

        void ClearLog();
    }
}
