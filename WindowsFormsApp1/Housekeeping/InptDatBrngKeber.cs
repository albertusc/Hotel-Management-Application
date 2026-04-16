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

namespace WindowsFormsApp1.Housekeeping
{
    public partial class InptDatBrngKeber : Form
    {
        public InptDatBrngKeber()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {

            string idBarang = IDBarang.Text;

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;

            string query = "SELECT IDBarang, NamaBarang, JumlahTersedia, Harga FROM BKebersihan WHERE IDBarang = @idBarang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idBarang", idBarang);

                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string retrievedIdBarang = reader.GetString(0);
                            string namaBarang = reader.GetString(1);
                            int jumlahTersedia = reader.GetInt32(2);
                            decimal harga = reader.GetDecimal(3);

                            NamaBarang.Text = namaBarang;
                            JumlahTersedia.Text = jumlahTersedia.ToString();
                            Hrg.Text = harga.ToString();
                        }


                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while searching for data: " + ex.Message);
                    }
                }
            }
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

            decimal harga;
            if (!decimal.TryParse(Hrg.Text, out harga))
            {
                MessageBox.Show("Invalid Harga input. Please enter a valid decimal value.");
                return;
            }

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;

            string query = "INSERT INTO BKebersihan (IDBarang, NamaBarang, JumlahTersedia, Harga) " +
                           "VALUES (@idBarang, @namaBarang, @jumlahTersedia, @harga)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idBarang", idBarang);
                    command.Parameters.AddWithValue("@namaBarang", namaBarang);
                    command.Parameters.AddWithValue("@jumlahTersedia", jumlahTersedia);
                    command.Parameters.AddWithValue("@harga", harga);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Berhasil diinput.");
                        }
                        else
                        {
                            MessageBox.Show("Data gagal diinput.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan penginputan dalam data: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string idBarang = IDBarang.Text;
            string namaBarang = NamaBarang.Text;
            int jumlahTersedia;
            if (!int.TryParse(JumlahTersedia.Text, out jumlahTersedia))
            {
                MessageBox.Show("Invalid JumlahTersedia input. Please enter a valid integer value.");
                return;
            }

            decimal harga;
            if (!decimal.TryParse(Hrg.Text, out harga))
            {
                MessageBox.Show("Invalid Harga input. Please enter a valid decimal value.");
                return;
            }

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;

            string query = "UPDATE BKebersihan SET NamaBarang = @namaBarang, JumlahTersedia = @jumlahTersedia, Harga = @harga WHERE IDBarang = @idBarang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idBarang", idBarang);
                    command.Parameters.AddWithValue("@namaBarang", namaBarang);
                    command.Parameters.AddWithValue("@jumlahTersedia", jumlahTersedia);
                    command.Parameters.AddWithValue("@harga", harga);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data successfully updated.");
                            this.bKebersihanTableAdapter.Fill(this.visProjectDataSet4.BKebersihan);
                        }
                        else
                        {
                            MessageBox.Show("Tidak ada Row yang diupdate");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Maaf terjadi kesalahan: " + ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string idBarang = IDBarang.Text;

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;

            string query = "DELETE FROM BKebersihan WHERE IDBarang = @idBarang";

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
                            this.bKebersihanTableAdapter.Fill(this.visProjectDataSet4.BKebersihan);
                        }
                        else
                        {
                            MessageBox.Show("Tidak ada column yang di delete, mohon mengecek kembali");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Maaf terjadi kesalahan: " + ex.Message);
                    }
                }
            }
        }

        private void InptDatBrngKeber_Load(object sender, EventArgs e)
        {
            this.bKebersihanTableAdapter.Fill(this.visProjectDataSet4.BKebersihan);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.bKebersihanTableAdapter.Fill(this.visProjectDataSet4.BKebersihan);
                MessageBox.Show("Data grid berhasil di refresh");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}



