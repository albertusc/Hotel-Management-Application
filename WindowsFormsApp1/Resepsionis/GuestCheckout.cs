using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GuestCheckout : Form
    {
        public GuestCheckout()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Tamu";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void GuestCheckout_Load(object sender, EventArgs e)
        {
            this.tamuTableAdapter.Fill(this.visProjectDataSet2.Tamu);

            LoadData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string roomNumber = selectedRow.Cells["RoomNumber"].Value.ToString();
                string idPelanggan = selectedRow.Cells["IDPelanggan"].Value.ToString();

                string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertRoomQuery = "INSERT INTO Room (RoomNumber) VALUES (@roomNumber)";
                    using (SqlCommand insertRoomCommand = new SqlCommand(insertRoomQuery, connection))
                    {
                        insertRoomCommand.Parameters.AddWithValue("@roomNumber", roomNumber);
                        insertRoomCommand.ExecuteNonQuery();
                    }


                    string deleteTamuQuery = "DELETE FROM Tamu WHERE IDPelanggan = @idPelanggan";
                    using (SqlCommand deleteTamuCommand = new SqlCommand(deleteTamuQuery, connection))
                    {
                        deleteTamuCommand.Parameters.AddWithValue("@idPelanggan", idPelanggan);
                        deleteTamuCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tamu berhasil di checkout!");

                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idPelanggan = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(idPelanggan))
            {
                string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Tamu WHERE IDPelanggan = @idPelanggan";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idPelanggan", idPelanggan);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            dataGridView1.DataSource = null;
                            MessageBox.Show("No data found for the provided IDPelanggan.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid IDPelanggan.");
            }
        }
    }
}



