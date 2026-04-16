namespace WindowsFormsApp1.Housekeeping
{
    partial class InptDatBrngKeber
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
            this.button4 = new System.Windows.Forms.Button();
            this.visProjectDataSet3 = new WindowsFormsApp1.VisProjectDataSet3();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter = new WindowsFormsApp1.VisProjectDataSet3TableAdapters.BarangTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IDBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Hrg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.JumlahTersedia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NamaBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.bKebersihanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.visProjectDataSet4 = new WindowsFormsApp1.VisProjectDataSet4();
            this.bKebersihanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bKebersihanTableAdapter = new WindowsFormsApp1.VisProjectDataSet4TableAdapters.BKebersihanTableAdapter();
            this.iDBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahTersediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKebersihanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKebersihanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(927, 525);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 59);
            this.button4.TabIndex = 57;
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
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(904, 798);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 59);
            this.button3.TabIndex = 56;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(558, 798);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 59);
            this.button2.TabIndex = 55;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(213, 798);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 59);
            this.button1.TabIndex = 54;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDBarang
            // 
            this.IDBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBarang.Location = new System.Drawing.Point(448, 533);
            this.IDBarang.Name = "IDBarang";
            this.IDBarang.Size = new System.Drawing.Size(456, 41);
            this.IDBarang.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 36);
            this.label5.TabIndex = 52;
            this.label5.Text = "ID Barang";
            // 
            // Hrg
            // 
            this.Hrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hrg.Location = new System.Drawing.Point(448, 736);
            this.Hrg.Name = "Hrg";
            this.Hrg.Size = new System.Drawing.Size(456, 41);
            this.Hrg.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 736);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 36);
            this.label4.TabIndex = 50;
            this.label4.Text = "Harga";
            // 
            // JumlahTersedia
            // 
            this.JumlahTersedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JumlahTersedia.Location = new System.Drawing.Point(448, 669);
            this.JumlahTersedia.Name = "JumlahTersedia";
            this.JumlahTersedia.Size = new System.Drawing.Size(456, 41);
            this.JumlahTersedia.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 669);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 36);
            this.label2.TabIndex = 48;
            this.label2.Text = "Jumlah Tersedia";
            // 
            // NamaBarang
            // 
            this.NamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaBarang.Location = new System.Drawing.Point(448, 596);
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.Size = new System.Drawing.Size(456, 41);
            this.NamaBarang.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 599);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 36);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 54);
            this.label1.TabIndex = 44;
            this.label1.Text = "Pendaftaran Barang Kebersihan";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(980, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 59);
            this.button5.TabIndex = 58;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bKebersihanBindingSource
            // 
            this.bKebersihanBindingSource.DataMember = "BKebersihan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBarangDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.jumlahTersediaDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bKebersihanBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1130, 423);
            this.dataGridView1.TabIndex = 59;
            // 
            // visProjectDataSet4
            // 
            this.visProjectDataSet4.DataSetName = "VisProjectDataSet4";
            this.visProjectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bKebersihanBindingSource1
            // 
            this.bKebersihanBindingSource1.DataMember = "BKebersihan";
            this.bKebersihanBindingSource1.DataSource = this.visProjectDataSet4;
            // 
            // bKebersihanTableAdapter
            // 
            this.bKebersihanTableAdapter.ClearBeforeFill = true;
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
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // InptDatBrngKeber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 886);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDBarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Hrg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.JumlahTersedia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NamaBarang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "InptDatBrngKeber";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InptDatBrngKeber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKebersihanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKebersihanBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private VisProjectDataSet3 visProjectDataSet3;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private VisProjectDataSet3TableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IDBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Hrg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox JumlahTersedia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NamaBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource bKebersihanBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VisProjectDataSet4 visProjectDataSet4;
        private System.Windows.Forms.BindingSource bKebersihanBindingSource1;
        private VisProjectDataSet4TableAdapters.BKebersihanTableAdapter bKebersihanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahTersediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
    }
}