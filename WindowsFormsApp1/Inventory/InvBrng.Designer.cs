namespace WindowsFormsApp1
{
    partial class InvBrng
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IDBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HargaSatuan = new System.Windows.Forms.TextBox();
            this.JumlahTersedia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NamaBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.visProjectDataSet3 = new WindowsFormsApp1.VisProjectDataSet3();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter = new WindowsFormsApp1.VisProjectDataSet3TableAdapters.BarangTableAdapter();
            this.iDBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahTersediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSatuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(885, 794);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 59);
            this.button3.TabIndex = 41;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(539, 794);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 59);
            this.button2.TabIndex = 40;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(194, 794);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 59);
            this.button1.TabIndex = 39;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDBarang
            // 
            this.IDBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBarang.Location = new System.Drawing.Point(429, 529);
            this.IDBarang.Name = "IDBarang";
            this.IDBarang.Size = new System.Drawing.Size(456, 41);
            this.IDBarang.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 36);
            this.label5.TabIndex = 37;
            this.label5.Text = "ID Barang";
            // 
            // HargaSatuan
            // 
            this.HargaSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HargaSatuan.Location = new System.Drawing.Point(429, 732);
            this.HargaSatuan.Name = "HargaSatuan";
            this.HargaSatuan.Size = new System.Drawing.Size(456, 41);
            this.HargaSatuan.TabIndex = 36;
            // 
            // JumlahTersedia
            // 
            this.JumlahTersedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JumlahTersedia.Location = new System.Drawing.Point(429, 665);
            this.JumlahTersedia.Name = "JumlahTersedia";
            this.JumlahTersedia.Size = new System.Drawing.Size(456, 41);
            this.JumlahTersedia.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 665);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 36);
            this.label2.TabIndex = 33;
            this.label2.Text = "Jumlah Tersedia";
            // 
            // NamaBarang
            // 
            this.NamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaBarang.Location = new System.Drawing.Point(429, 592);
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.Size = new System.Drawing.Size(456, 41);
            this.NamaBarang.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 36);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nama Barang";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBarangDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.jumlahTersediaDataGridViewTextBoxColumn,
            this.hargaSatuanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.barangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1124, 415);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 54);
            this.label1.TabIndex = 29;
            this.label1.Text = "Pendaftaran Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 732);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 36);
            this.label4.TabIndex = 35;
            this.label4.Text = "Harga Satuan";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(908, 521);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 59);
            this.button4.TabIndex = 42;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // visProjectDataSet3
            // 
            this.visProjectDataSet3.DataSetName = "VisProjectDataSet3";
            this.visProjectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.visProjectDataSet3;
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // iDBarangDataGridViewTextBoxColumn
            // 
            this.iDBarangDataGridViewTextBoxColumn.DataPropertyName = "IDBarang";
            this.iDBarangDataGridViewTextBoxColumn.HeaderText = "IDBarang";
            this.iDBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDBarangDataGridViewTextBoxColumn.Name = "iDBarangDataGridViewTextBoxColumn";
            this.iDBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            this.namaBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahTersediaDataGridViewTextBoxColumn
            // 
            this.jumlahTersediaDataGridViewTextBoxColumn.DataPropertyName = "JumlahTersedia";
            this.jumlahTersediaDataGridViewTextBoxColumn.HeaderText = "JumlahTersedia";
            this.jumlahTersediaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahTersediaDataGridViewTextBoxColumn.Name = "jumlahTersediaDataGridViewTextBoxColumn";
            this.jumlahTersediaDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaSatuanDataGridViewTextBoxColumn
            // 
            this.hargaSatuanDataGridViewTextBoxColumn.DataPropertyName = "HargaSatuan";
            this.hargaSatuanDataGridViewTextBoxColumn.HeaderText = "HargaSatuan";
            this.hargaSatuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaSatuanDataGridViewTextBoxColumn.Name = "hargaSatuanDataGridViewTextBoxColumn";
            this.hargaSatuanDataGridViewTextBoxColumn.Width = 125;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(961, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 59);
            this.button5.TabIndex = 43;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // InvBrng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 870);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDBarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HargaSatuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.JumlahTersedia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NamaBarang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "InvBrng";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.InvBrng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IDBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HargaSatuan;
        private System.Windows.Forms.TextBox JumlahTersedia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NamaBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private VisProjectDataSet3 visProjectDataSet3;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private VisProjectDataSet3TableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahTersediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}