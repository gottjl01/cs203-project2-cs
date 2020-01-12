namespace PFW.CSIST203.Project2
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtBusinessPhone = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Button5 = new System.Windows.Forms.Button();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button4 = new System.Windows.Forms.Button();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog1";
            this.OpenFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(148, 331);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(145, 20);
            this.txtTitle.TabIndex = 38;
            // 
            // txtCompany
            // 
            this.txtCompany.Enabled = false;
            this.txtCompany.Location = new System.Drawing.Point(148, 292);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(145, 20);
            this.txtCompany.TabIndex = 37;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(39, 334);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(47, 13);
            this.Label7.TabIndex = 36;
            this.Label7.Text = "Job Title";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(41, 295);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(51, 13);
            this.Label6.TabIndex = 35;
            this.Label6.Text = "Company";
            // 
            // txtBusinessPhone
            // 
            this.txtBusinessPhone.Enabled = false;
            this.txtBusinessPhone.Location = new System.Drawing.Point(148, 251);
            this.txtBusinessPhone.Name = "txtBusinessPhone";
            this.txtBusinessPhone.Size = new System.Drawing.Size(145, 20);
            this.txtBusinessPhone.TabIndex = 34;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(39, 255);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(83, 13);
            this.Label5.TabIndex = 33;
            this.Label5.Text = "Business Phone";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // Button5
            // 
            this.Button5.Enabled = false;
            this.Button5.Location = new System.Drawing.Point(141, 402);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(75, 23);
            this.Button5.TabIndex = 32;
            this.Button5.Text = "Reset";
            this.Button5.UseVisualStyleBackColor = true;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // Button4
            // 
            this.Button4.Enabled = false;
            this.Button4.Location = new System.Drawing.Point(60, 402);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 23);
            this.Button4.TabIndex = 31;
            this.Button4.Text = "Save";
            this.Button4.UseVisualStyleBackColor = true;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Enabled = false;
            this.txtEmailAddress.Location = new System.Drawing.Point(148, 211);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(145, 20);
            this.txtEmailAddress.TabIndex = 30;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(38, 218);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(77, 13);
            this.Label4.TabIndex = 29;
            this.Label4.Text = "E-Mail Address";
            // 
            // txtLastname
            // 
            this.txtLastname.Enabled = false;
            this.txtLastname.Location = new System.Drawing.Point(148, 173);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(145, 20);
            this.txtLastname.TabIndex = 28;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(38, 180);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(58, 13);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "Last Name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(39, 146);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(57, 13);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "First Name";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Enabled = false;
            this.txtFirstname.Location = new System.Drawing.Point(148, 139);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(145, 20);
            this.txtFirstname.TabIndex = 25;
            // 
            // Button3
            // 
            this.Button3.Enabled = false;
            this.Button3.Location = new System.Drawing.Point(222, 402);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 23);
            this.Button3.TabIndex = 24;
            this.Button3.Text = "New Entry";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(229, 83);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "Next ->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(67, 83);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 22;
            this.btnPrevious.Text = "<- Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(158, 69);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 13);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "Excel Row";
            // 
            // txtRow
            // 
            this.txtRow.Enabled = false;
            this.txtRow.Location = new System.Drawing.Point(148, 85);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(75, 20);
            this.txtRow.TabIndex = 20;
            this.txtRow.Text = "0";
            this.txtRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(334, 24);
            this.MenuStrip1.TabIndex = 39;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 447);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtBusinessPhone);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project #2";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog;
        internal System.Windows.Forms.TextBox txtTitle;
        internal System.Windows.Forms.TextBox txtCompany;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtBusinessPhone;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ErrorProvider ErrorProvider;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.TextBox txtEmailAddress;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtLastname;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtFirstname;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.Button btnPrevious;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtRow;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
    }
}

