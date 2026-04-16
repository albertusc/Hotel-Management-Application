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

namespace WindowsFormsApp1
{
    public partial class InvBrng : Form
    {
        public InvBrng()
        {
            InitializeComponent();
        }

        private void InvBrng_Load(object sender, EventArgs e)
        {
            this.barangTableAdapter.Fill(this.visProjectDataSet3.Barang);

        }

        private void LoadData()
        {
            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Barang";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string idBarang = IDBarang.Text;

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT NamaBarang, JumlahTersedia, HargaSatuan FROM Barang WHERE IDBarang = @idBarang";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idBarang", idBarang);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string namaBarang = reader.GetString(reader.GetOrdinal("NamaBarang"));
                            int jumlahTersedia = reader.GetInt32(reader.GetOrdinal("JumlahTersedia"));
                            decimal hargaSatuan = reader.GetDecimal(reader.GetOrdinal("HargaSatuan"));

                            NamaBarang.Text = namaBarang;
                            JumlahTersedia.Text = jumlahTersedia.ToString();
                            HargaSatuan.Text = hargaSatuan.ToString();

                        }
                        else
                        {
                            MessageBox.Show("No record found for the given IDBarang.");
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string idBarang = IDBarang.Text;
            string namaBarang = NamaBarang.Text;
            int jumlahTersedia;
            if (!int.TryParse(JumlahTersedia.Text, out jumlahTersedia))
            {
                MessageBox.Show("Invalid JumlahTersedia input. Please enter a valid integer value.");
                return;
            }

            decimal hargaSatuan;
            if (!decimal.TryParse(HargaSatuan.Text, out hargaSatuan))
            {
                MessageBox.Show("Invalid HargaSatuan input. Please enter a valid decimal value.");
                return;
            }

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;

            string query = "INSERT INTO Barang (IDBarang, NamaBarang, JumlahTersedia, HargaSatuan) " +
                           "VALUES (@idBarang, @namaBarang, @jumlahTersedia, @hargaSatuan)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idBarang", idBarang);
                    command.Parameters.AddWithValue("@namaBarang", namaBarang);
                    command.Parameters.AddWithValue("@jumlahTersedia", jumlahTersedia);
                    command.Parameters.AddWithValue("@hargaSatuan", hargaSatuan);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Berhasil di Input");
                        }
                        else
                        {
                            MessageBox.Show("Data gagal di Input");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan penginputan dalam data: " + ex.Message);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string idBarang = IDBarang.Text;
            string namaBarang = NamaBarang.Text;
            int jumlahTersedia;
            if (!int.TryParse(JumlahTersedia.Text, out jumlahTersedia))
            {
                MessageBox.Show("Invalid JumlahTersedia input. Tolong masukkan angka dan pastikan tidak ada huruf");
                return;
            }

            decimal hargaSatuan;
            if (!decimal.TryParse(HargaSatuan.Text, out hargaSatuan))
            {
                MessageBox.Show("Invalid HargaSatuan input. tolong masukkan value decimal.");
                return;
            }

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;

            string query = "UPDATE Barang SET NamaBarang = @namaBarang, JumlahTersedia = @jumlahTersedia, HargaSatuan = @hargaSatuan WHERE IDBarang = @idBarang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idBarang", idBarang);
                    command.Parameters.AddWithValue("@namaBarang", namaBarang);
                    command.Parameters.AddWithValue("@jumlahTersedia", jumlahTersedia);
                    command.Parameters.AddWithValue("@hargaSatuan", hargaSatuan);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data successfully updated.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("No rows updated. Please check the IDBarang value.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating data: " + ex.Message);
                    }
                }
            }
        }

        private void ClearFields()
        {
            IDBarang.Text = "";
            NamaBarang.Text = "";
            JumlahTersedia.Text = "";
            HargaSatuan.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string idBarang = IDBarang.Text;

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;

            string query = "DELETE FROM Barang WHERE IDBarang = @idBarang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idBarang", idBarang);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data successfully deleted.");
                            LoadData();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("No rows deleted. Please check the IDBarang value.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting data: " + ex.Message);
                    }
                }
            }

        }
    }
}



