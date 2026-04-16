namespace WindowsFormsApp1
{
    partial class GuestR
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
            this.IDPelanggan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NamaLengkap = new System.Windows.Forms.TextBox();
            this.NoTelp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Inser = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.TglLahir = new System.Windows.Forms.DateTimePicker();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservasi";
            // 
            // IDPelanggan
            // 
            this.IDPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPelanggan.Location = new System.Drawing.Point(331, 124);
            this.IDPelanggan.Name = "IDPelanggan";
            this.IDPelanggan.Size = new System.Drawing.Size(456, 41);
            this.IDPelanggan.TabIndex = 1;
            this.IDPelanggan.TextChanged += new System.EventHandler(this.IDPelanggan_TextChanged);
            this.IDPelanggan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Lengkap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tgl. Lahir";
            // 
            // NamaLengkap
            // 
            this.NamaLengkap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaLengkap.Location = new System.Drawing.Point(331, 188);
            this.NamaLengkap.Name = "NamaLengkap";
            this.NamaLengkap.Size = new System.Drawing.Size(456, 41);
            this.NamaLengkap.TabIndex = 5;
            this.NamaLengkap.TextChanged += new System.EventHandler(this.NamaLengkap_TextChanged);
            // 
            // NoTelp
            // 
            this.NoTelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoTelp.Location = new System.Drawing.Point(331, 322);
            this.NoTelp.Name = "NoTelp";
            this.NoTelp.Size = new System.Drawing.Size(456, 41);
            this.NoTelp.TabIndex = 7;
            this.NoTelp.TextChanged += new System.EventHandler(this.NoTelp_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "Male";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "No Telp.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(331, 399);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(456, 41);
            this.Email.TabIndex = 11;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gender";
            // 
            // Inser
            // 
            this.Inser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inser.Location = new System.Drawing.Point(83, 548);
            this.Inser.Name = "Inser";
            this.Inser.Size = new System.Drawing.Size(161, 59);
            this.Inser.TabIndex = 14;
            this.Inser.Text = "Insert";
            this.Inser.UseVisualStyleBackColor = true;
            this.Inser.Click += new System.EventHandler(this.Save_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(388, 548);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(161, 59);
            this.Update.TabIndex = 16;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(694, 548);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(161, 59);
            this.Delete.TabIndex = 17;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // TglLahir
            // 
            this.TglLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TglLahir.Location = new System.Drawing.Point(331, 261);
            this.TglLahir.Name = "TglLahir";
            this.TglLahir.Size = new System.Drawing.Size(456, 38);
            this.TglLahir.TabIndex = 20;
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(331, 474);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(456, 39);
            this.Gender.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(793, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 59);
            this.button2.TabIndex = 22;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(892, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 261);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(17, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 59);
            this.button3.TabIndex = 9;
            this.button3.Text = "Female";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GuestR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 640);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.TglLahir);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Inser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NoTelp);
            this.Controls.Add(this.NamaLengkap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDPelanggan);
            this.Controls.Add(this.label1);
            this.Name = "GuestR";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.GuestR_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDPelanggan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NamaLengkap;
        private System.Windows.Forms.TextBox NoTelp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Inser;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DateTimePicker TglLahir;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
    }
}