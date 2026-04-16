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
using WindowsFormsApp1.Resepsionis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class GuestR : Form
    {
        string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;

        public GuestR()
        {
            InitializeComponent();
            Update.Click += Update_Click;
            Delete.Click += Delete_Click;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = IDPelanggan.Text.Trim();

                string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Pelanggan WHERE IDPelanggan = @searchText";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", searchText);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string namaLengkap = reader.GetString(1);
                                DateTime tglLahir = reader.GetDateTime(2);
                                string noTelp = reader.GetString(3);
                                string email = reader.GetString(4);
                                string gender = reader.GetString(5);

                                NamaLengkap.Text = namaLengkap;
                                TglLahir.Value = tglLahir;
                                NoTelp.Text = noTelp;
                                Email.Text = email;
                                Gender.SelectedItem = gender;
                            }
                            else
                            {
                                NamaLengkap.Text = "";
                                TglLahir.Value = DateTime.Today; 
                                NoTelp.Text = "";
                                Email.Text = "";
                                Gender.SelectedItem = null; 
                            }
                        }
                    }
                }
            }
        }

        private void NamaLengkap_TextChanged(object sender, EventArgs e)
        {

        }

        private void TglLahir_TextChanged(object sender, EventArgs e)
        {

        }

        private void NoTelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Pelanggan (IDPelanggan, NamaLengkap, TglLahir, NoTelp, Email, Gender) " +
                    "VALUES (@idPelanggan, @namaLengkap, @tglLahir, @noTelp, @email, @gender)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@idPelanggan", IDPelanggan.Text);
                    command.Parameters.AddWithValue("@namaLengkap", NamaLengkap.Text);
                    command.Parameters.AddWithValue("@tglLahir", TglLahir.Value); 
                    command.Parameters.AddWithValue("@noTelp", NoTelp.Text);
                    command.Parameters.AddWithValue("@email", Email.Text);
                    command.Parameters.AddWithValue("@gender", Gender.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Data Berhasil Dimasukkan!");
                }
            }
        }

        private void IDPelanggan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Pelanggan SET NamaLengkap = @namaLengkap, TglLahir = @tglLahir, " +
                    "NoTelp = @noTelp, Email = @email, Gender = @gender " +
                    "WHERE IDPelanggan = @idPelanggan";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@idPelanggan", IDPelanggan.Text);
                    command.Parameters.AddWithValue("@namaLengkap", NamaLengkap.Text);
                    command.Parameters.AddWithValue("@tglLahir", TglLahir.Value);
                    command.Parameters.AddWithValue("@noTelp", NoTelp.Text);
                    command.Parameters.AddWithValue("@email", Email.Text);
                    command.Parameters.AddWithValue("@gender", Gender.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Berhasil Diperbarui!");
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan!");
                    }
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Pelanggan WHERE IDPelanggan = @idPelanggan";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@idPelanggan", IDPelanggan.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus!");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan!");
                    }
                }
            }
        }

        private void ClearFields()
        {
            IDPelanggan.Text = "";
            NamaLengkap.Text = "";
            TglLahir.Value = DateTime.Now; 
            NoTelp.Text = "";
            Email.Text = "";
            Gender.Text = "";
        }

        //male
        private void button1_Click(object sender, EventArgs e)
        {
            FormDataReserv formDataReserv = new FormDataReserv();
            DataReservUnsort report = new DataReservUnsort();

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Pelanggan ORDER BY Gender ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            report.RecordSelectionFormula = "{Pelanggan.Gender} = \"Male\"";

            report.SetDataSource(dataTable);

            formDataReserv.crystalReportViewer1.ReportSource = report;
            formDataReserv.crystalReportViewer1.RefreshReport();

            formDataReserv.Show();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            FormDataReservUnsort DatResUn = new FormDataReservUnsort();
            DatResUn.Show();
        }

        //female
        private void button3_Click(object sender, EventArgs e)
        {
            FormDataReserv formDataReserv = new FormDataReserv();
            DataReservUnsort report = new DataReservUnsort();

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Pelanggan ORDER BY Gender ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            report.RecordSelectionFormula = "{Pelanggan.Gender} = \"Female\"";

            report.SetDataSource(dataTable);

            formDataReserv.crystalReportViewer1.ReportSource = report;
            formDataReserv.crystalReportViewer1.RefreshReport();

            formDataReserv.Show();
        }

        private void GuestR_Load(object sender, EventArgs e)
        {

        }
    }
}



