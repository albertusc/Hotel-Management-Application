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

namespace WindowsFormsApp1.Inventory
{
    public partial class PemStok : Form
    {
        public PemStok()
        {
            InitializeComponent();
        }

        private void PemStok_Load(object sender, EventArgs e)
        {
            this.barangTableAdapter.Fill(this.visProjectDataSet3.Barang);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string idBarang = IDBarang.Text;

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;

            string query = "SELECT IDBarang, NamaBarang, JumlahTersedia, HargaSatuan FROM Barang WHERE IDBarang = @idBarang";

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
                            decimal hargaSatuan = reader.GetDecimal(3);

                            DataTable dataTable = new DataTable();
                            dataTable.Columns.Add("IDBarang", typeof(string));
                            dataTable.Columns.Add("NamaBarang", typeof(string));
                            dataTable.Columns.Add("JumlahTersedia", typeof(int));
                            dataTable.Columns.Add("HargaSatuan", typeof(decimal));

                            dataTable.Rows.Add(retrievedIdBarang, namaBarang, jumlahTersedia, hargaSatuan);

                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given IDBarang.");
                            dataGridView1.DataSource = null; 
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
            string sortOrder = string.Empty;

            if (Ascending.Checked)
            {
                sortOrder = "ASC";
            }
            else if (Descending.Checked)
            {
                sortOrder = "DESC";
            }
            else
            {
                MessageBox.Show("Please select the sort order.");
                return;
            }

            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;

            string query = $"SELECT IDBarang, NamaBarang, JumlahTersedia, HargaSatuan FROM Barang ORDER BY JumlahTersedia {sortOrder}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No records found in the table.");
                            dataGridView1.DataSource = null; 
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while sorting data: " + ex.Message);
                    }
                }
            }
        }

        private void Adcending_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            string connectionString = WindowsFormsApp1.Properties.Settings.Default.VisProjectConnectionString;

            string query = "SELECT IDBarang, NamaBarang, JumlahTersedia, HargaSatuan FROM Barang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No records found in the table.");
                            dataGridView1.DataSource = null; 
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading data: " + ex.Message);
                    }
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}



