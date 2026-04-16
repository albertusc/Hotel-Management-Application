using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Housekeeping
{
    public partial class KetersediaanKebersihan : Form
    {
        public KetersediaanKebersihan()
        {
            InitializeComponent();
        }

        private void KetersediaanKebersihan_Load(object sender, EventArgs e)
        {
            this.bKebersihanTableAdapter.Fill(this.visProjectDataSet4.BKebersihan);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchNamaBarang = IDBarang.Text;

            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["NamaBarang"].Value != null && row.Cells["NamaBarang"].Value.ToString().Equals(searchNamaBarang, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Nama Barang not found in the DataGridView.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string columnName = "JumlahTersedia";

            if (Ascending.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[columnName], ListSortDirection.Ascending);
            }
            else if (Descending.Checked)
            {
                dataGridView1.Sort(dataGridView1.Columns[columnName], ListSortDirection.Descending);
            }
        }
    }
}
