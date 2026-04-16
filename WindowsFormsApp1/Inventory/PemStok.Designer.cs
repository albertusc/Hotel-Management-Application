namespace WindowsFormsApp1.Inventory
{
    partial class PemStok
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.IDBarang = new System.Windows.Forms.TextBox();
            this.Ascending = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Descending = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahTersediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSatuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visProjectDataSet3 = new WindowsFormsApp1.VisProjectDataSet3();
            this.barangTableAdapter = new WindowsFormsApp1.VisProjectDataSet3TableAdapters.BarangTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 54);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tampilan Persediaan Barang";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(669, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 59);
            this.button2.TabIndex = 42;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IDBarang
            // 
            this.IDBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBarang.Location = new System.Drawing.Point(230, 514);
            this.IDBarang.Name = "IDBarang";
            this.IDBarang.Size = new System.Drawing.Size(388, 41);
            this.IDBarang.TabIndex = 41;
            // 
            // Ascending
            // 
            this.Ascending.AutoSize = true;
            this.Ascending.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ascending.Location = new System.Drawing.Point(432, 646);
            this.Ascending.Name = "Ascending";
            this.Ascending.Size = new System.Drawing.Size(169, 36);
            this.Ascending.TabIndex = 43;
            this.Ascending.TabStop = true;
            this.Ascending.Text = "Ascending";
            this.Ascending.UseVisualStyleBackColor = true;
            this.Ascending.CheckedChanged += new System.EventHandler(this.Adcending_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 591);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 32);
            this.label2.TabIndex = 44;
            this.label2.Text = "Sorting Jumlah Barang";
            // 
            // Descending
            // 
            this.Descending.AutoSize = true;
            this.Descending.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descending.Location = new System.Drawing.Point(432, 688);
            this.Descending.Name = "Descending";
            this.Descending.Size = new System.Drawing.Size(186, 36);
            this.Descending.TabIndex = 45;
            this.Descending.TabStop = true;
            this.Descending.Text = "Descending";
            this.Descending.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(432, 757);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 59);
            this.button1.TabIndex = 46;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1124, 415);
            this.dataGridView1.TabIndex = 47;
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
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.visProjectDataSet3;
            // 
            // visProjectDataSet3
            // 
            this.visProjectDataSet3.DataSetName = "VisProjectDataSet3";
            this.visProjectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(970, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 51);
            this.button3.TabIndex = 48;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PemStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 870);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Descending);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ascending);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.IDBarang);
            this.Controls.Add(this.label1);
            this.Name = "PemStok";
            this.Text = "PemStok";
            this.Load += new System.EventHandler(this.PemStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox IDBarang;
        private System.Windows.Forms.RadioButton Ascending;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Descending;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VisProjectDataSet3 visProjectDataSet3;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private VisProjectDataSet3TableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahTersediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}