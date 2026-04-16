namespace WindowsFormsApp1.Administrasi
{
    partial class PengDK
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.IDKaryawan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Alamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NoTelp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NamaLengkap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Jabatan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.visProjectDataSet5 = new WindowsFormsApp1.VisProjectDataSet5();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WindowsFormsApp1.VisProjectDataSet5TableAdapters.UsersTableAdapter();
            this.iDKaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaLengkapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 54);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tampilan Daftar Karyawan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKaryawanDataGridViewTextBoxColumn,
            this.namaLengkapDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.jabatanDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.noTelpDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1152, 367);
            this.dataGridView1.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(757, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 49);
            this.button2.TabIndex = 51;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IDKaryawan
            // 
            this.IDKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDKaryawan.Location = new System.Drawing.Point(318, 512);
            this.IDKaryawan.Name = "IDKaryawan";
            this.IDKaryawan.Size = new System.Drawing.Size(388, 41);
            this.IDKaryawan.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 36);
            this.label5.TabIndex = 52;
            this.label5.Text = "ID Karyawan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 694);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 36);
            this.label3.TabIndex = 56;
            this.label3.Text = "Jabatan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 754);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 36);
            this.label4.TabIndex = 58;
            this.label4.Text = "Alamat";
            // 
            // Alamat
            // 
            this.Alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alamat.Location = new System.Drawing.Point(318, 749);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(388, 41);
            this.Alamat.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 816);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 36);
            this.label6.TabIndex = 60;
            this.label6.Text = "No.Telp";
            // 
            // NoTelp
            // 
            this.NoTelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoTelp.Location = new System.Drawing.Point(318, 811);
            this.NoTelp.Name = "NoTelp";
            this.NoTelp.Size = new System.Drawing.Size(388, 41);
            this.NoTelp.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(757, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 49);
            this.button1.TabIndex = 61;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(757, 629);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 49);
            this.button3.TabIndex = 62;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NamaLengkap
            // 
            this.NamaLengkap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaLengkap.Location = new System.Drawing.Point(318, 575);
            this.NamaLengkap.Name = "NamaLengkap";
            this.NamaLengkap.Size = new System.Drawing.Size(388, 41);
            this.NamaLengkap.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 36);
            this.label2.TabIndex = 63;
            this.label2.Text = "Nama Lengkap";
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(318, 632);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(388, 41);
            this.Username.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 632);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 36);
            this.label7.TabIndex = 65;
            this.label7.Text = "Username";
            // 
            // Jabatan
            // 
            this.Jabatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jabatan.FormattingEnabled = true;
            this.Jabatan.Items.AddRange(new object[] {
            "Resepsionis",
            "Inventory ",
            "Housekeeping",
            "Administrasi "});
            this.Jabatan.Location = new System.Drawing.Point(318, 691);
            this.Jabatan.Name = "Jabatan";
            this.Jabatan.Size = new System.Drawing.Size(388, 44);
            this.Jabatan.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 873);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 36);
            this.label8.TabIndex = 68;
            this.label8.Text = "Password";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(318, 868);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(388, 41);
            this.Password.TabIndex = 67;
            // 
            // visProjectDataSet5
            // 
            this.visProjectDataSet5.DataSetName = "VisProjectDataSet5";
            this.visProjectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.visProjectDataSet5;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // iDKaryawanDataGridViewTextBoxColumn
            // 
            this.iDKaryawanDataGridViewTextBoxColumn.DataPropertyName = "IDKaryawan";
            this.iDKaryawanDataGridViewTextBoxColumn.HeaderText = "IDKaryawan";
            this.iDKaryawanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDKaryawanDataGridViewTextBoxColumn.Name = "iDKaryawanDataGridViewTextBoxColumn";
            this.iDKaryawanDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaLengkapDataGridViewTextBoxColumn
            // 
            this.namaLengkapDataGridViewTextBoxColumn.DataPropertyName = "NamaLengkap";
            this.namaLengkapDataGridViewTextBoxColumn.HeaderText = "NamaLengkap";
            this.namaLengkapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaLengkapDataGridViewTextBoxColumn.Name = "namaLengkapDataGridViewTextBoxColumn";
            this.namaLengkapDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // jabatanDataGridViewTextBoxColumn
            // 
            this.jabatanDataGridViewTextBoxColumn.DataPropertyName = "Jabatan";
            this.jabatanDataGridViewTextBoxColumn.HeaderText = "Jabatan";
            this.jabatanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jabatanDataGridViewTextBoxColumn.Name = "jabatanDataGridViewTextBoxColumn";
            this.jabatanDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // noTelpDataGridViewTextBoxColumn
            // 
            this.noTelpDataGridViewTextBoxColumn.DataPropertyName = "NoTelp";
            this.noTelpDataGridViewTextBoxColumn.HeaderText = "NoTelp";
            this.noTelpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noTelpDataGridViewTextBoxColumn.Name = "noTelpDataGridViewTextBoxColumn";
            this.noTelpDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(757, 694);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 49);
            this.button4.TabIndex = 69;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(757, 763);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 49);
            this.button5.TabIndex = 70;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PengDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 936);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Jabatan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NoTelp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Alamat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NamaLengkap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.IDKaryawan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "PengDK";
            this.Text = "PengDK";
            this.Load += new System.EventHandler(this.PengDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visProjectDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox IDKaryawan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Alamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NoTelp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox NamaLengkap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Jabatan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Password;
        private VisProjectDataSet5 visProjectDataSet5;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private VisProjectDataSet5TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaLengkapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}