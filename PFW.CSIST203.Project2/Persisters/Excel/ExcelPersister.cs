using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace PFW.CSIST203.Project2.Persisters.Excel
{
    /// <summary>
    /// Excel Persister that interacts with data in an xls or xlsx file
    /// </summary>
    public class ExcelPersister : IPersistData
    {
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(ExcelPersister));

        private System.Data.DataTable _Data = null;

        /// <summary>
        /// This data table must be populated with all data contained in the specified excel file
        /// </summary>
        /// <remarks>
        /// DO NOT EDIT
        /// </remarks>
        internal System.Data.DataTable Data
        {
            get
            {
                return _Data;
            }
            private set
            {
                _Data = value;
            }
        }

        private bool _isDisposed = false;

        /// <summary>
        /// Get a value indicating whether or not the object has been disposed
        /// </summary>
        /// <remarks>
        /// DO NOT EDIT
        /// </remarks>
        internal bool isDisposed
        {
            get
            {
                return _isDisposed;
            }
            private set
            {
                _isDisposed = value;
            }
        }


        /// <summary>
        /// This contructor creates a persister that contains no data
        /// </summary>
        /// <remarks>
        /// DO NOT EDIT
        /// </remarks>
        public ExcelPersister()
        {
            Data = new DataTable("Sheet1");
            Data.Columns.AddRange(new DataColumn[] {
                new DataColumn("First Name", typeof(string)),
                new DataColumn("Last Name", typeof(string)),
                new DataColumn("E-mail Address", typeof(string)),
                new DataColumn("Business Phone", typeof(string)),
                new DataColumn("Company", typeof(string)),
                new DataColumn("Job Title", typeof(string))
            });
        }

        public ExcelPersister(string excelFilepath)
        {
            // TODO: Implement
        }

        public System.Data.DataRow GetRow(int rowNumber)
        {
            // TODO: Implement
            throw new NotImplementedException();
        }

        public int CountRows()
        {
            // TODO: Implement
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            // TODO: Implement
        }
    }

}
