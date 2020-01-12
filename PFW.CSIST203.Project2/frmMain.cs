using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFW.CSIST203.Project2
{

    public partial class frmMain : Form
    {
        internal PFW.CSIST203.Project2.Persisters.Excel.ExcelPersister persister;

        /// <summary>
        /// Initializes the form
        /// </summary>
        /// <remarks>
        /// DO NOT EDIT
        /// </remarks>
        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // TODO: Implement
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            // TODO: Implement
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // TODO: Implement
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // TODO: Implement
        }

        /// <summary>
        /// Handle the File -> Open dialog box used for selecting the excel file that is utilized by the front-end
        /// </summary>
        /// <remarks>
        /// DO NOT EDIT
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = OpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                persister.Dispose();
                persister = new PFW.CSIST203.Project2.Persisters.Excel.ExcelPersister(OpenFileDialog.FileName);
                txtRow.Text = "0"; // reset back to zero
                txtFirstname.Text = string.Empty;
                txtLastname.Text = string.Empty;
                txtEmailAddress.Text = string.Empty;
                txtBusinessPhone.Text = string.Empty;
                txtCompany.Text = string.Empty;
                txtTitle.Text = string.Empty;
            }
        }
    }

}
