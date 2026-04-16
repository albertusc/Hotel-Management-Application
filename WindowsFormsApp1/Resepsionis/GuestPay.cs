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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class GuestPay : Form
    {
        public GuestPay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idPelanggan = IDPelanggan.Text.Trim();

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT NamaLengkap, TglLahir, NoTelp, Email, Gender FROM Pelanggan WHERE IDPelanggan = @idPelanggan";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idPelanggan", idPelanggan);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string namaLengkap = reader.GetString(0);
                            DateTime tglLahir = reader.GetDateTime(1);
                            string noTelp = reader.GetString(2);
                            string email = reader.GetString(3);
                            string gender = reader.GetString(4);

                            NamaLengkap.Text = namaLengkap;
                            TglLahir.Value = tglLahir;
                            NoTelp.Text = noTelp;
                            Email.Text = email;
                            Gender.Text = gender;
                        }
                        else
                        {
                            NamaLengkap.Text = "";
                            TglLahir.Value = DateTime.Now;
                            NoTelp.Text = "";
                            Email.Text = "";
                            Gender.Text = "";
                            MessageBox.Show("No record found for the given ID.");
                        }
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idPelanggan = IDPelanggan.Text.Trim();
            string namaLengkap = NamaLengkap.Text.Trim();
            DateTime tglLahir = DateTime.Parse(TglLahir.Text);
            string noTelp = NoTelp.Text.Trim();
            string email = Email.Text.Trim();
            string gender = Gender.Text.Trim();
            int jumlahKamar = int.Parse(JumlahKamar.Text);
            int jumlahHari = int.Parse(JumlahHari.Text);
            string metodePembayaran = MetodePembayaran.SelectedItem.ToString();
            int totalHarga = int.Parse(Total.Text);
            int roomNumber = int.Parse(RoomNumb.Text); 

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string roomAvailabilityQuery = "SELECT COUNT(*) FROM Room WHERE RoomNumber = @roomNumber AND RoomNumber NOT IN (SELECT RoomNumber FROM Tamu)";
                using (SqlCommand roomAvailabilityCommand = new SqlCommand(roomAvailabilityQuery, connection))
                {
                    roomAvailabilityCommand.Parameters.AddWithValue("@roomNumber", roomNumber);
                    int roomCount = (int)roomAvailabilityCommand.ExecuteScalar();

                    if (roomCount == 0)
                    {
                        MessageBox.Show("Maaf, ruangan tidak tersedia.");
                        return;
                    }
                }

                string insertQuery = "INSERT INTO Tamu (IDPelanggan, NamaLengkap, TglLahir, NoTelp, Email, Gender, JumlahKamar, JumlahHari, MetodePembayaran, TotalHarga, RoomNumber) " +
                                     "VALUES (@idPelanggan, @namaLengkap, @tglLahir, @noTelp, @email, @gender, @jumlahKamar, @jumlahHari, @metodePembayaran, @totalHarga, @roomNumber)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@idPelanggan", idPelanggan);
                    command.Parameters.AddWithValue("@namaLengkap", namaLengkap);
                    command.Parameters.AddWithValue("@tglLahir", tglLahir);
                    command.Parameters.AddWithValue("@noTelp", noTelp);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@jumlahKamar", jumlahKamar);
                    command.Parameters.AddWithValue("@jumlahHari", jumlahHari);
                    command.Parameters.AddWithValue("@metodePembayaran", metodePembayaran);
                    command.Parameters.AddWithValue("@totalHarga", totalHarga);
                    command.Parameters.AddWithValue("@roomNumber", roomNumber);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dipindahkan ke tabel Tamu!");

                    string removeRoomQuery = "DELETE FROM Room WHERE RoomNumber = @roomNumber";
                    using (SqlCommand removeRoomCommand = new SqlCommand(removeRoomQuery, connection))
                    {
                        removeRoomCommand.Parameters.AddWithValue("@roomNumber", roomNumber);
                        removeRoomCommand.ExecuteNonQuery();
                    }
                }

                string deleteQuery = "DELETE FROM Pelanggan WHERE IDPelanggan = @idPelanggan";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@idPelanggan", idPelanggan);

                    command.ExecuteNonQuery();
                }
            }


        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(JumlahKamar.Text) && !string.IsNullOrEmpty(JumlahHari.Text))
            {
                int jumlahKamar = int.Parse(JumlahKamar.Text);
                int jumlahHari = int.Parse(JumlahHari.Text);

                int total = (jumlahKamar * 300000) * jumlahHari;

                Total.Text = total.ToString();
            }
            else
            {
                Total.Text = "";
                MessageBox.Show("Please enter values for Jumlah Kamar and Jumlah Hari.");
            }
        }

        private void GuestPay_Load(object sender, EventArgs e)
        {

        }
    }
}




