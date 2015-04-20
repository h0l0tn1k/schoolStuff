using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04
{
    /// <summary>
    /// Interface for Printing machine
    /// </summary>
    interface IPrintingMachine
    {
        /// <summary>
        /// Prints text on printing machine
        /// </summary>
        /// <param name="text">text to be printed</param>
        void Print(string text);
        /// <summary>
        /// Shows name of the printer,for example "HP c4480"
        /// </summary>
        /// <returns>name of printer</returns>
        string ToString();
    }
}
