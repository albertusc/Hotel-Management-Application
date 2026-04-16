using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Administrasi
{
    public partial class SisPeng : Form
    {
        public SisPeng()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string idKaryawan = IDKaryawan.Text;

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
            string query = "SELECT NamaLengkap, Jabatan FROM users WHERE IDKaryawan = @IDKaryawan";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDKaryawan", idKaryawan);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Nama.Text = reader["NamaLengkap"].ToString();
                        Jabatan.Text = reader["Jabatan"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Data not found.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string idKaryawan = IDKaryawan.Text;
            string nama = Nama.Text;
            string jabatan = Jabatan.Text;
            string gajiPokok = GajiPokok.Text;
            string tunjangan = Tunjangan.Text;
            string potongan = Potongan.Text;
            string totalGaji = TotalGaji.Text;

            string filePath = GetPayrollFilePath();

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"ID Karyawan: {idKaryawan}");
                    writer.WriteLine($"Nama: {nama}");
                    writer.WriteLine($"Jabatan: {jabatan}");
                    writer.WriteLine($"Gaji Pokok: {gajiPokok}");
                    writer.WriteLine($"Tunjangan: {tunjangan}");
                    writer.WriteLine($"Potongan: {potongan}");
                    writer.WriteLine($"Total Gaji: {totalGaji}");
                    writer.WriteLine(new string('-', 30));
                }

                MessageBox.Show("Data has been successfully inserted into the text file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to the text file: {ex.Message}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string gajiPokokText = GajiPokok.Text;
            string tunjanganText = Tunjangan.Text;
            string potonganText = Potongan.Text;

            if (decimal.TryParse(gajiPokokText, out decimal gajiPokok) &&
                decimal.TryParse(tunjanganText, out decimal tunjangan) &&
                decimal.TryParse(potonganText, out decimal potongan))
            {
                decimal totalGaji = gajiPokok + tunjangan - potongan;

                TotalGaji.Text = totalGaji.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter numeric values for Gaji Pokok, Tunjangan, and Potongan.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string filePath = GetPayrollFilePath();

            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("ID Karyawan: " + IDKaryawan2.Text))
                {
                    string namaLine = lines[i + 1];
                    string jabatanLine = lines[i + 2];
                    string gajiPokokLine = lines[i + 3];
                    string tunjanganLine = lines[i + 4];
                    string potonganLine = lines[i + 5];
                    string totalGajiLine = lines[i + 6];

                    string nama = namaLine.Substring(namaLine.IndexOf(": ") + 2);
                    string jabatan = jabatanLine.Substring(jabatanLine.IndexOf(": ") + 2);
                    string gajiPokok = gajiPokokLine.Substring(gajiPokokLine.IndexOf(": ") + 2);
                    string tunjangan = tunjanganLine.Substring(tunjanganLine.IndexOf(": ") + 2);
                    string potongan = potonganLine.Substring(potonganLine.IndexOf(": ") + 2);
                    string totalGaji = totalGajiLine.Substring(totalGajiLine.IndexOf(": ") + 2);

                    Nama2.Text = nama;
                    Jabatan2.Text = jabatan;
                    GajiPokok2.Text = gajiPokok;
                    Tunjangan2.Text = tunjangan;
                    Potongan2.Text = potongan;
                    TotalGaji2.Text = totalGaji;

                    break;
                }
            }
        }

        private void SisPeng_Load(object sender, EventArgs e)
        {

        }

        private string GetPayrollFilePath()
        {
            return Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "Txt", "DataGaji.txt"));
        }
    }
}



