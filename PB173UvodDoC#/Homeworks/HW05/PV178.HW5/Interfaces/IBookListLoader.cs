using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV178.HW5
{
    /// <summary>
    /// Toto rozhraní slouží implementaci zdroje seznamu předepsané literatury.
    /// </summary>
    internal interface IBookListLoader
    {
        /// <summary>
        /// Načte seznam předepsané literatury.
        /// </summary>
        /// <returns>Kolekce záznamů předepsané literatury.</returns>
        IEnumerable<BookListRecord> LoadList();
    }
}
