using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PFW.CSIST203.Project2.Tests
{
    /// <summary>
    /// frmMain testing harness
    /// </summary>
    public abstract class frmMainTests : TestBase
    {

        /// <summary>
        /// Helper method that creates a form, allows a series of statements to execute and then clearly closes down the form
        /// </summary>
        /// <param name="action">The testing actions taken after the instantiation of the form object</param>
        protected void CreateTemporaryForm(Action<frmMain> action)
        {
            using (var form = new frmMain())
            {
                try
                {
                    form.Show();
                    action(form);
                    form.Visible = false;
                }
                catch (Exception ex)
                {
                    logger.Error("Error creating temporary form or executing statements during test: ", ex);
                    throw;
                }
                finally
                {
                    if (null != form)
                        form.Close();
                }
            }
        }

        /// <summary>
        /// LoadMethod event handler testing harness
        /// </summary>
        [TestClass]
        public class FrmMain_LoadMethod : frmMainTests
        {

            /// <summary>
            ///     Verify the state of the form when the event is raised
            ///     </summary>
            [TestMethod]
            public void EventRaised()
            {
                CreateTemporaryForm(form =>
                {
                    Assert.IsNotNull(form.persister, "The Load method should have caused the instantiation of the persister");
                });
            }
        }

        /// <summary>
        /// btnPrevious Click event testing harness
        /// </summary>
        [TestClass]
        public class BtnPrevious_ClickMethod : frmMainTests
        {

            /// <summary>
            ///     Verify the state of the form when the event is raised
            ///     </summary>
            [TestMethod]
            public void EventRaised()
            {
                var directory = GetMethodSpecificWorkingDirectory();
                var tmpExcelFile = System.IO.Path.Combine(directory, "data006.xlsx");
                CopyEmbeddedResourceBaseToDirectory("PFW.CSIST203.Project2.Tests.Resources.Form.BtnPrevious_Click.EventRaised", directory);
                Assert.IsTrue(System.IO.File.Exists(tmpExcelFile), "The testing file used does not exist");

                CreateTemporaryForm(form =>
                {
                    form.persister = new Project2.Persisters.Excel.ExcelPersister(tmpExcelFile);
                    form.txtRow.Text = "4"; // artificially set the selected row to 4 in the excel file
                    AssertDelegateSuccess(() => form.btnPrevious.PerformClick(), "Failure when clicking the button");

                    // retrieve the data row from the persister
                    var row = form.persister.GetRow(2);

                    // Verify the data points displayed are in fact consistent with the row in question
                    Assert.AreEqual(row["First Name"], form.txtFirstname.Text, "The displayed first name is not correct");
                    Assert.AreEqual(row["Last Name"], form.txtLastname.Text, "The displayed last name is not correct");
                    Assert.AreEqual(row["E-mail Address"], form.txtEmailAddress.Text, "The displayed email is not correct");
                    Assert.AreEqual(row["Business Phone"], form.txtBusinessPhone.Text, "The displayed business phone is not correct");
                    Assert.AreEqual(row["Company"], form.txtCompany.Text, "The displayed company is not correct");
                    Assert.AreEqual(row["Job Title"], form.txtTitle.Text, "The displayed job title is not correct");
                });
            }
        }

        /// <summary>
        /// btnNext Click testing harness
        /// </summary>
        [TestClass]
        public class BtnNext_ClickMethod : frmMainTests
        {

            /// <summary>
            ///     Verify the state of the form when the event is raised
            ///     </summary>
            [TestMethod]
            public void EventRaised()
            {
                var directory = GetMethodSpecificWorkingDirectory();
                var tmpExcelFile = System.IO.Path.Combine(directory, "data007.xlsx");
                CopyEmbeddedResourceBaseToDirectory("PFW.CSIST203.Project2.Tests.Resources.Form.BtnNext_Click.EventRaised", directory);
                Assert.IsTrue(System.IO.File.Exists(tmpExcelFile), "The testing file used does not exist");

                CreateTemporaryForm(form =>
                {
                    form.persister = new Project2.Persisters.Excel.ExcelPersister(tmpExcelFile);
                    form.txtRow.Text = "3"; // artificially set the selected row to 4 in the excel file
                    AssertDelegateSuccess(() => form.btnNext.PerformClick(), "Failure when clicking the button");

                    // retrieve the data row from the persister
                    var row = form.persister.GetRow(3);

                    // Verify the data points displayed are in fact consistent with the row in question
                    Assert.AreEqual(row["First Name"], form.txtFirstname.Text, "The displayed first name is not correct");
                    Assert.AreEqual(row["Last Name"], form.txtLastname.Text, "The displayed last name is not correct");
                    Assert.AreEqual(row["E-mail Address"], form.txtEmailAddress.Text, "The displayed email is not correct");
                    Assert.AreEqual(row["Business Phone"], form.txtBusinessPhone.Text, "The displayed business phone is not correct");
                    Assert.AreEqual(row["Company"], form.txtCompany.Text, "The displayed company is not correct");
                    Assert.AreEqual(row["Job Title"], form.txtTitle.Text, "The displayed job title is not correct");
                });
            }
        }

        /// <summary>
        /// frmMain OnFormClosing event handler testing harness
        /// </summary>
        [TestClass]
        public class OnFormClosingMethod : frmMainTests
        {

            /// <summary>
            /// Verify the state of the form when the event is raised
            /// </summary>
            [TestMethod]
            public void EventRaised()
            {
                frmMain tmp = null;
                CreateTemporaryForm(form =>
                {
                    tmp = form;
                });
                Assert.IsNull(tmp.persister, "The persister variable should have been set to null upon form close");
            }
        }
    }

}
