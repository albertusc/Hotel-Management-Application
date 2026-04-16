namespace WindowsFormsApp1.Resepsionis
{
    partial class FormDataReserv
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.DataReservUnsort2 = new WindowsFormsApp1.Resepsionis.DataReservUnsort();
            this.DataReserv2 = new WindowsFormsApp1.Resepsionis.DataReserv();
            this.DataReserv1 = new WindowsFormsApp1.Resepsionis.DataReserv();
            this.DataReservUnsort1 = new WindowsFormsApp1.Resepsionis.DataReservUnsort();
            this.DataReservUnsort3 = new WindowsFormsApp1.Resepsionis.DataReservUnsort();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1054, 540);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // DataReserv2
            // 
            this.DataReserv2.InitReport += new System.EventHandler(this.DataReserv2_InitReport);
            // 
            // DataReserv1
            // 
            this.DataReserv1.InitReport += new System.EventHandler(this.DataReserv1_InitReport);
            // 
            // FormDataReserv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 540);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FormDataReserv";
            this.Text = "FormDataReserv";
            this.Load += new System.EventHandler(this.FormDataReserv_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DataReserv DataReserv1;
        private DataReserv DataReserv2;
        private DataReservUnsort DataReservUnsort2;
        private DataReservUnsort DataReservUnsort1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private DataReservUnsort DataReservUnsort3;
    }
}