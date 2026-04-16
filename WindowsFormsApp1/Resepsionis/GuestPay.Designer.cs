namespace WindowsFormsApp1
{
    partial class GuestPay
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.IDPelanggan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RoomNumb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MetodePembayaran = new System.Windows.Forms.ComboBox();
            this.JumlahHari = new System.Windows.Forms.TextBox();
            this.JumlahKamar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.TglLahir = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NoTelp = new System.Windows.Forms.TextBox();
            this.NamaLengkap = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pembayaran";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(753, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 59);
            this.button1.TabIndex = 19;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDPelanggan
            // 
            this.IDPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPelanggan.Location = new System.Drawing.Point(385, 130);
            this.IDPelanggan.Name = "IDPelanggan";
            this.IDPelanggan.Size = new System.Drawing.Size(329, 41);
            this.IDPelanggan.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 42);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RoomNumb);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Total);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MetodePembayaran);
            this.groupBox1.Controls.Add(this.JumlahHari);
            this.groupBox1.Controls.Add(this.JumlahKamar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(885, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 467);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tagihan Tamu";
            // 
            // RoomNumb
            // 
            this.RoomNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumb.Location = new System.Drawing.Point(333, 255);
            this.RoomNumb.Name = "RoomNumb";
            this.RoomNumb.Size = new System.Drawing.Size(181, 41);
            this.RoomNumb.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(67, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 36);
            this.label13.TabIndex = 30;
            this.label13.Text = "Room Number";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(520, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 59);
            this.button3.TabIndex = 29;
            this.button3.Text = "Hitung";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(333, 183);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(181, 41);
            this.Total.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 36);
            this.label6.TabIndex = 27;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 36);
            this.label5.TabIndex = 26;
            this.label5.Text = "Hari";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(482, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 59);
            this.button2.TabIndex = 25;
            this.button2.Text = "Proses Pembayaran";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 36);
            this.label7.TabIndex = 24;
            this.label7.Text = "Metode Pembayaran";
            // 
            // MetodePembayaran
            // 
            this.MetodePembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetodePembayaran.FormattingEnabled = true;
            this.MetodePembayaran.Items.AddRange(new object[] {
            "Cash",
            "Credit",
            "Debit"});
            this.MetodePembayaran.Location = new System.Drawing.Point(333, 352);
            this.MetodePembayaran.Name = "MetodePembayaran";
            this.MetodePembayaran.Size = new System.Drawing.Size(456, 44);
            this.MetodePembayaran.TabIndex = 23;
            // 
            // JumlahHari
            // 
            this.JumlahHari.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JumlahHari.Location = new System.Drawing.Point(333, 121);
            this.JumlahHari.Name = "JumlahHari";
            this.JumlahHari.Size = new System.Drawing.Size(181, 41);
            this.JumlahHari.TabIndex = 18;
            // 
            // JumlahKamar
            // 
            this.JumlahKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JumlahKamar.Location = new System.Drawing.Point(333, 59);
            this.JumlahKamar.Name = "JumlahKamar";
            this.JumlahKamar.Size = new System.Drawing.Size(456, 41);
            this.JumlahKamar.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 36);
            this.label4.TabIndex = 16;
            this.label4.Text = "Durasi Menginap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = " Jumlah Kamar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Gender);
            this.groupBox2.Controls.Add(this.TglLahir);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Email);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.NoTelp);
            this.groupBox2.Controls.Add(this.NamaLengkap);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 410);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tagihan Tamu";
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(308, 335);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(456, 39);
            this.Gender.TabIndex = 33;
            // 
            // TglLahir
            // 
            this.TglLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TglLahir.Location = new System.Drawing.Point(308, 122);
            this.TglLahir.Name = "TglLahir";
            this.TglLahir.Size = new System.Drawing.Size(456, 38);
            this.TglLahir.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 36);
            this.label8.TabIndex = 31;
            this.label8.Text = "Gender";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(308, 260);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(456, 41);
            this.Email.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(133, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 36);
            this.label9.TabIndex = 29;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(123, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 36);
            this.label10.TabIndex = 28;
            this.label10.Text = "No Telp.";
            // 
            // NoTelp
            // 
            this.NoTelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoTelp.Location = new System.Drawing.Point(308, 183);
            this.NoTelp.Name = "NoTelp";
            this.NoTelp.Size = new System.Drawing.Size(456, 41);
            this.NoTelp.TabIndex = 27;
            // 
            // NamaLengkap
            // 
            this.NamaLengkap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaLengkap.Location = new System.Drawing.Point(308, 49);
            this.NamaLengkap.Name = "NamaLengkap";
            this.NamaLengkap.Size = new System.Drawing.Size(456, 41);
            this.NamaLengkap.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(111, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 36);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tgl. Lahir";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(73, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 36);
            this.label12.TabIndex = 24;
            this.label12.Text = "Nama Lengkap";
            // 
            // GuestPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 732);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDPelanggan);
            this.Controls.Add(this.label1);
            this.Name = "GuestPay";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.GuestPay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IDPelanggan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox JumlahKamar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox MetodePembayaran;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox JumlahHari;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.DateTimePicker TglLahir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NoTelp;
        private System.Windows.Forms.TextBox NamaLengkap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox RoomNumb;
        private System.Windows.Forms.Label label13;
    }
}