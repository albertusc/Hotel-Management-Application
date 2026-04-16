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
    public partial class RoomReserv : Form
    {
        public RoomReserv()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void RoomReserv_Load(object sender, EventArgs e)
        {
            this.roomTableAdapter.Fill(this.visProjectDataSet.Room);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string roomNumberToSearch = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(roomNumberToSearch))
            {
                MessageBox.Show("Tolong masukkan nomor ruangan.");
                return;
            }

            bool roomFound = false;
            int columnIndex = -1;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.HeaderText == "RoomNumber")
                {
                    columnIndex = column.Index;
                    break;
                }
            }

            if (columnIndex == -1)
            {
                MessageBox.Show("Nomor ruangan tidak ditemukan.");
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string roomNumber = row.Cells[columnIndex].Value?.ToString();

                if (roomNumber == roomNumberToSearch)
                {
                    dataGridView1.ClearSelection();
                    row.Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;

                    roomFound = true;
                    break;
                }
            }

            if (!roomFound)
            {
                MessageBox.Show("Nomor ruangan tidak ditemukan.");
            }
        }
    }
}
