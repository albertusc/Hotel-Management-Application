namespace WindowsFormsApp1.Housekeeping
{
    partial class KetersediaanKebersihan
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
            this.button1 = new System.Windows.Forms.Button();
            this.Descending = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Ascending = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.IDBarang = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bKebersihanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.visProjectDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visProjectDataSet4 = new WindowsFormsApp1.VisProjectDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.bKebersihanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bKebersihanTableAdapter = new WindowsFormsApp1.VisProjectDataSet4TableAdapters.BKebersihanTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahTersedia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKebersihanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKebersihanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(515, 737);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 59);
            this.button1.TabIndex = 61;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Descending
            // 
            this.Descending.AutoSize = true;
            this.Descending.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descending.Location = new System.Drawing.Point(515, 668);
            this.Descending.Name = "Descending";
            this.Descending.Size = new System.Drawing.Size(186, 36);
            this.Descending.TabIndex = 60;
            this.Descending.TabStop = true;
            this.Descending.Text = "Descending";
            this.Descending.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 32);
            this.label2.TabIndex = 59;
            this.label2.Text = "Sorting Jumlah Barang";
            // 
            // Ascending
            // 
            this.Ascending.AutoSize = true;
            this.Ascending.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ascending.Location = new System.Drawing.Point(515, 626);
            this.Ascending.Name = "Ascending";
            this.Ascending.Size = new System.Drawing.Size(169, 36);
            this.Ascending.TabIndex = 58;
            this.Ascending.TabStop = true;
            this.Ascending.Text = "Ascending";
            this.Ascending.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(752, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 59);
            this.button2.TabIndex = 57;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IDBarang
            // 
            this.IDBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBarang.Location = new System.Drawing.Point(313, 494);
            this.IDBarang.Name = "IDBarang";
            this.IDBarang.Size = new System.Drawing.Size(388, 41);
            this.IDBarang.TabIndex = 56;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamaBarang,
            this.JumlahTersedia,
            this.Harga});
            this.dataGridView1.DataSource = this.bKebersihanBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(95, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1139, 347);
            this.dataGridView1.TabIndex = 55;
            // 
            // bKebersihanBindingSource1
            // 
            this.bKebersihanBindingSource1.DataMember = "BKebersihan";
            this.bKebersihanBindingSource1.DataSource = this.visProjectDataSet4BindingSource;
            // 
            // visProjectDataSet4BindingSource
            // 
            this.visProjectDataSet4BindingSource.DataSource = this.visProjectDataSet4;
            this.visProjectDataSet4BindingSource.Position = 0;
            // 
            // visProjectDataSet4
            // 
            this.visProjectDataSet4.DataSetName = "VisProjectDataSet4";
            this.visProjectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(811, 54);
            this.label1.TabIndex = 54;
            this.label1.Text = "Tampilan Laporan Barang Kebersihan";
            // 
            // bKebersihanBindingSource
            // 
            this.bKebersihanBindingSource.DataMember = "BKebersihan";
            this.bKebersihanBindingSource.DataSource = this.visProjectDataSet4BindingSource;
            // 
            // bKebersihanTableAdapter
            // 
            this.bKebersihanTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 32);
            this.label3.TabIndex = 62;
            this.label3.Text = "Nama Barang";
            // 
            // NamaBarang
            // 
            this.NamaBarang.DataPropertyName = "NamaBarang";
            this.NamaBarang.HeaderText = "NamaBarang";
            this.NamaBarang.MinimumWidth = 6;
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.Width = 125;
            // 
            // JumlahTersedia
            // 
            this.JumlahTersedia.DataPropertyName = "JumlahTersedia";
            this.JumlahTersedia.HeaderText = "JumlahTersedia";
            this.JumlahTersedia.MinimumWidth = 6;
            this.JumlahTersedia.Name = "JumlahTersedia";
            this.JumlahTersedia.Width = 125;
            // 
            // Harga
            // 
            this.Harga.DataPropertyName = "Harga";
            this.Harga.HeaderText = "Harga";
            this.Harga.MinimumWidth = 6;
            this.Harga.Name = "Harga";
            this.Harga.Width = 125;
            // 
            // KetersediaanKebersihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 818);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Descending);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ascending);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.IDBarang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "KetersediaanKebersihan";
            this.Text = "KetersediaanBarang";
            this.Load += new System.EventHandler(this.KetersediaanKebersihan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKebersihanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKebersihanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Descending;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Ascending;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox IDBarang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource visProjectDataSet4BindingSource;
        private VisProjectDataSet4 visProjectDataSet4;
        private System.Windows.Forms.BindingSource bKebersihanBindingSource;
        private VisProjectDataSet4TableAdapters.BKebersihanTableAdapter bKebersihanTableAdapter;
        private System.Windows.Forms.BindingSource bKebersihanBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahTersedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
    }
}