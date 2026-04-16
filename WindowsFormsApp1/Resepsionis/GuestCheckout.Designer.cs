namespace WindowsFormsApp1
{
    partial class GuestCheckout
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDPelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaLengkap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TglLahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoTelp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahKamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahHari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetodePembayaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaLengkapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahKamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahHariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodePembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.visProjectDataSet2 = new WindowsFormsApp1.VisProjectDataSet2();
            this.checkoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visProjectDataSet1 = new WindowsFormsApp1.VisProjectDataSet1();
            this.visProjectDataSet = new WindowsFormsApp1.VisProjectDataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new WindowsFormsApp1.VisProjectDataSetTableAdapters.RoomTableAdapter();
            this.checkoutTableAdapter = new WindowsFormsApp1.VisProjectDataSet1TableAdapters.CheckoutTableAdapter();
            this.tamuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tamuTableAdapter = new WindowsFormsApp1.VisProjectDataSet2TableAdapters.TamuTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(445, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 54);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 42);
            this.label1.TabIndex = 19;
            this.label1.Text = "Check Out";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(251, 450);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 41);
            this.textBox1.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(22, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 59);
            this.button2.TabIndex = 21;
            this.button2.Text = "Check-Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 42);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tamu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 602);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservasi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPelanggan,
            this.NamaLengkap,
            this.TglLahir,
            this.NoTelp,
            this.Email,
            this.Gender,
            this.JumlahKamar,
            this.JumlahHari,
            this.MetodePembayaran,
            this.TotalHarga,
            this.RoomNumber,
            this.iDPelangganDataGridViewTextBoxColumn,
            this.namaLengkapDataGridViewTextBoxColumn,
            this.tglLahirDataGridViewTextBoxColumn,
            this.noTelpDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.jumlahKamarDataGridViewTextBoxColumn,
            this.jumlahHariDataGridViewTextBoxColumn,
            this.metodePembayaranDataGridViewTextBoxColumn,
            this.totalHargaDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tamuBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(22, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(826, 322);
            this.dataGridView1.TabIndex = 2;
            // 
            // IDPelanggan
            // 
            this.IDPelanggan.DataPropertyName = "IDPelanggan";
            this.IDPelanggan.HeaderText = "IDPelanggan";
            this.IDPelanggan.MinimumWidth = 6;
            this.IDPelanggan.Name = "IDPelanggan";
            this.IDPelanggan.Width = 125;
            // 
            // NamaLengkap
            // 
            this.NamaLengkap.DataPropertyName = "NamaLengkap";
            this.NamaLengkap.HeaderText = "NamaLengkap";
            this.NamaLengkap.MinimumWidth = 6;
            this.NamaLengkap.Name = "NamaLengkap";
            this.NamaLengkap.Width = 125;
            // 
            // TglLahir
            // 
            this.TglLahir.DataPropertyName = "TglLahir";
            this.TglLahir.HeaderText = "TglLahir";
            this.TglLahir.MinimumWidth = 6;
            this.TglLahir.Name = "TglLahir";
            this.TglLahir.Width = 125;
            // 
            // NoTelp
            // 
            this.NoTelp.DataPropertyName = "NoTelp";
            this.NoTelp.HeaderText = "NoTelp";
            this.NoTelp.MinimumWidth = 6;
            this.NoTelp.Name = "NoTelp";
            this.NoTelp.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // JumlahKamar
            // 
            this.JumlahKamar.DataPropertyName = "JumlahKamar";
            this.JumlahKamar.HeaderText = "JumlahKamar";
            this.JumlahKamar.MinimumWidth = 6;
            this.JumlahKamar.Name = "JumlahKamar";
            this.JumlahKamar.Width = 125;
            // 
            // JumlahHari
            // 
            this.JumlahHari.DataPropertyName = "JumlahHari";
            this.JumlahHari.HeaderText = "JumlahHari";
            this.JumlahHari.MinimumWidth = 6;
            this.JumlahHari.Name = "JumlahHari";
            this.JumlahHari.Width = 125;
            // 
            // MetodePembayaran
            // 
            this.MetodePembayaran.DataPropertyName = "MetodePembayaran";
            this.MetodePembayaran.HeaderText = "MetodePembayaran";
            this.MetodePembayaran.MinimumWidth = 6;
            this.MetodePembayaran.Name = "MetodePembayaran";
            this.MetodePembayaran.Width = 125;
            // 
            // TotalHarga
            // 
            this.TotalHarga.DataPropertyName = "TotalHarga";
            this.TotalHarga.HeaderText = "TotalHarga";
            this.TotalHarga.MinimumWidth = 6;
            this.TotalHarga.Name = "TotalHarga";
            this.TotalHarga.Width = 125;
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomNumber";
            this.RoomNumber.HeaderText = "RoomNumber";
            this.RoomNumber.MinimumWidth = 6;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Width = 125;
            // 
            // iDPelangganDataGridViewTextBoxColumn
            // 
            this.iDPelangganDataGridViewTextBoxColumn.DataPropertyName = "IDPelanggan";
            this.iDPelangganDataGridViewTextBoxColumn.HeaderText = "IDPelanggan";
            this.iDPelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPelangganDataGridViewTextBoxColumn.Name = "iDPelangganDataGridViewTextBoxColumn";
            this.iDPelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaLengkapDataGridViewTextBoxColumn
            // 
            this.namaLengkapDataGridViewTextBoxColumn.DataPropertyName = "NamaLengkap";
            this.namaLengkapDataGridViewTextBoxColumn.HeaderText = "NamaLengkap";
            this.namaLengkapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaLengkapDataGridViewTextBoxColumn.Name = "namaLengkapDataGridViewTextBoxColumn";
            this.namaLengkapDataGridViewTextBoxColumn.Width = 125;
            // 
            // tglLahirDataGridViewTextBoxColumn
            // 
            this.tglLahirDataGridViewTextBoxColumn.DataPropertyName = "TglLahir";
            this.tglLahirDataGridViewTextBoxColumn.HeaderText = "TglLahir";
            this.tglLahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tglLahirDataGridViewTextBoxColumn.Name = "tglLahirDataGridViewTextBoxColumn";
            this.tglLahirDataGridViewTextBoxColumn.Width = 125;
            // 
            // noTelpDataGridViewTextBoxColumn
            // 
            this.noTelpDataGridViewTextBoxColumn.DataPropertyName = "NoTelp";
            this.noTelpDataGridViewTextBoxColumn.HeaderText = "NoTelp";
            this.noTelpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noTelpDataGridViewTextBoxColumn.Name = "noTelpDataGridViewTextBoxColumn";
            this.noTelpDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahKamarDataGridViewTextBoxColumn
            // 
            this.jumlahKamarDataGridViewTextBoxColumn.DataPropertyName = "JumlahKamar";
            this.jumlahKamarDataGridViewTextBoxColumn.HeaderText = "JumlahKamar";
            this.jumlahKamarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahKamarDataGridViewTextBoxColumn.Name = "jumlahKamarDataGridViewTextBoxColumn";
            this.jumlahKamarDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahHariDataGridViewTextBoxColumn
            // 
            this.jumlahHariDataGridViewTextBoxColumn.DataPropertyName = "JumlahHari";
            this.jumlahHariDataGridViewTextBoxColumn.HeaderText = "JumlahHari";
            this.jumlahHariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahHariDataGridViewTextBoxColumn.Name = "jumlahHariDataGridViewTextBoxColumn";
            this.jumlahHariDataGridViewTextBoxColumn.Width = 125;
            // 
            // metodePembayaranDataGridViewTextBoxColumn
            // 
            this.metodePembayaranDataGridViewTextBoxColumn.DataPropertyName = "MetodePembayaran";
            this.metodePembayaranDataGridViewTextBoxColumn.HeaderText = "MetodePembayaran";
            this.metodePembayaranDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.metodePembayaranDataGridViewTextBoxColumn.Name = "metodePembayaranDataGridViewTextBoxColumn";
            this.metodePembayaranDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalHargaDataGridViewTextBoxColumn
            // 
            this.totalHargaDataGridViewTextBoxColumn.DataPropertyName = "TotalHarga";
            this.totalHargaDataGridViewTextBoxColumn.HeaderText = "TotalHarga";
            this.totalHargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalHargaDataGridViewTextBoxColumn.Name = "totalHargaDataGridViewTextBoxColumn";
            this.totalHargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // tamuBindingSource1
            // 
            this.tamuBindingSource1.DataMember = "Tamu";
            this.tamuBindingSource1.DataSource = this.visProjectDataSet2;
            // 
            // visProjectDataSet2
            // 
            this.visProjectDataSet2.DataSetName = "VisProjectDataSet2";
            this.visProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkoutBindingSource
            // 
            this.checkoutBindingSource.DataMember = "Checkout";
            this.checkoutBindingSource.DataSource = this.visProjectDataSet1;
            // 
            // visProjectDataSet1
            // 
            this.visProjectDataSet1.DataSetName = "VisProjectDataSet1";
            this.visProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visProjectDataSet
            // 
            this.visProjectDataSet.DataSetName = "VisProjectDataSet";
            this.visProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.visProjectDataSet;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // checkoutTableAdapter
            // 
            this.checkoutTableAdapter.ClearBeforeFill = true;
            // 
            // tamuBindingSource
            // 
            this.tamuBindingSource.DataMember = "Tamu";
            this.tamuBindingSource.DataSource = this.visProjectDataSet2;
            // 
            // tamuTableAdapter
            // 
            this.tamuTableAdapter.ClearBeforeFill = true;
            // 
            // GuestCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 719);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "GuestCheckout";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.GuestCheckout_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private VisProjectDataSet visProjectDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private VisProjectDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private VisProjectDataSet1 visProjectDataSet1;
        private System.Windows.Forms.BindingSource checkoutBindingSource;
        private VisProjectDataSet1TableAdapters.CheckoutTableAdapter checkoutTableAdapter;
        private VisProjectDataSet2 visProjectDataSet2;
        private System.Windows.Forms.BindingSource tamuBindingSource;
        private VisProjectDataSet2TableAdapters.TamuTableAdapter tamuTableAdapter;
        private System.Windows.Forms.BindingSource tamuBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaLengkap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TglLahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoTelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahHari;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetodePembayaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaLengkapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglLahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahKamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahHariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodePembayaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
    }
}