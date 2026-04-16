using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string jabatan = reader["Jabatan"].ToString();

                    Form2 form2 = new Form2(jabatan);
                    this.Hide();
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username atau password salah. Silakan coba lagi.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menghubungi database: " + ex.Message, "Kesalahan Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



