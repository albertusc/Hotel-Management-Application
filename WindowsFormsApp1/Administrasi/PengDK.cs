using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Administrasi
{
    public partial class PengDK : Form
    {
        public PengDK()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int userId = int.Parse(IDKaryawan.Text);

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT * FROM Users WHERE IDKaryawan = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NamaLengkap.Text = reader["NamaLengkap"].ToString();
                    Username.Text = reader["Username"].ToString();
                    Jabatan.Text = reader["Jabatan"].ToString();
                    Alamat.Text = reader["Alamat"].ToString();
                    NoTelp.Text = reader["NoTelp"].ToString();
                    Password.Text = reader["Password"].ToString();
                }
                else
                {
                    MessageBox.Show("User ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accessing the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void PengDK_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.visProjectDataSet5.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idKaryawan = IDKaryawan.Text;
            string namaLengkap = NamaLengkap.Text;
            string username = Username.Text;
            string jabatan = Jabatan.Text;
            string alamat = Alamat.Text;
            string noTelp = NoTelp.Text;
            string password = Password.Text;

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "INSERT INTO Users (IDKaryawan, NamaLengkap, Username, Jabatan, Alamat, NoTelp, Password) VALUES (@IDKaryawan, @NamaLengkap, @Username, @Jabatan, @Alamat, @NoTelp, @Password)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDKaryawan", idKaryawan);
                command.Parameters.AddWithValue("@NamaLengkap", namaLengkap);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Jabatan", jabatan);
                command.Parameters.AddWithValue("@Alamat", alamat);
                command.Parameters.AddWithValue("@NoTelp", noTelp);
                command.Parameters.AddWithValue("@Password", password);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accessing the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string idKaryawan = IDKaryawan.Text;
            string namaLengkap = NamaLengkap.Text;
            string username = Username.Text;
            string jabatan = Jabatan.Text;
            string alamat = Alamat.Text;
            string noTelp = NoTelp.Text;
            string password = Password.Text;

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "UPDATE Users SET NamaLengkap = @NamaLengkap, Username = @Username, Jabatan = @Jabatan, Alamat = @Alamat, NoTelp = @NoTelp, Password = @Password WHERE IDKaryawan = @IDKaryawan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDKaryawan", idKaryawan);
                command.Parameters.AddWithValue("@NamaLengkap", namaLengkap);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Jabatan", jabatan);
                command.Parameters.AddWithValue("@Alamat", alamat);
                command.Parameters.AddWithValue("@NoTelp", noTelp);
                command.Parameters.AddWithValue("@Password", password);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accessing the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string idKaryawan = IDKaryawan.Text;

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "DELETE FROM Users WHERE IDKaryawan = @IDKaryawan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDKaryawan", idKaryawan);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accessing the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void RefreshDataGridView()
        {
            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
            string query = "SELECT * FROM Users";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accessing the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}



