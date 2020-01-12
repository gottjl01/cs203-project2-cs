using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFW.CSIST203.Project2.Persisters
{
    /// <summary>
    /// Generic interface used for persisting data to and from a data source
    /// </summary>
    public interface IPersistData : IDisposable
    {

        /// <summary>
        /// Retrieves a specific row number from the data source using a unique ID
        /// </summary>
        /// <param name="id">The unique identifier used by this persister to retrieve specific rows</param>
        /// <returns>The data row representing the requested data</returns>
        System.Data.DataRow GetRow(int id);

        /// <summary>
        /// Retrieves a count of the number of elements present in the data source
        /// </summary>
        /// <returns>The number of items present in the underlying data source</returns>
        int CountRows();
    }

}
