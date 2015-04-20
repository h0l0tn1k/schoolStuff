using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04
{
    /// <summary>
    /// Printing machine implementation, prints on command line
    /// </summary>
    class CommandLinePrinter : IPrintingMachine
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
        public override string ToString()
        {
            return string.Format("Command line");
        }
    }
}
