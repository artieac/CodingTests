using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imprivata
{
    /// <summary>
    ///  Typcically I'd just use lof4net and log to a file
    ///  but I wanted something visual in the win form and
    ///  didn't have the time to figure out how to make those work 
    ///  together.
    /// </summary>
    public class OutputWindowManager
    {
        public OutputWindowManager()
        {
            this.OutputData = new List<string>();
        }

        public IList<string> OutputData { get; private set; }

        public void AddMessage(string message)
        {
            this.OutputData.Add(message);
        }

        public void Clear()
        {
            this.OutputData.Clear();
        }
    }
}
