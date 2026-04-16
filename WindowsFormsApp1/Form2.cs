using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using WindowsFormsApp1.Administrasi;
using WindowsFormsApp1.Housekeeping;
using WindowsFormsApp1.Inventory;
using WindowsFormsApp1.Resepsionis;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private string userRole;


        public Form2(string role)
        {
            InitializeComponent();
            userRole = role;
            SetMenuAvailability();
        }

        public string Username { get; set; }

        private void SetMenuAvailability()
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.Enabled = false;
            }

            if (userRole == "Resepsionis")
            {
                testToolStripMenuItem.Enabled = true;
                closeToolStripMenuItem.Enabled = true;
            }
            else if (userRole == "Inventory")
            {
                testToolStripMenuItem1.Enabled = true;
                closeToolStripMenuItem.Enabled = true;

            }
            else if (userRole == "Housekeeping")
            {
                housekeepingToolStripMenuItem.Enabled = true;
                closeToolStripMenuItem.Enabled = true;

            }
            else if (userRole == "Administrasi")
            {
                testToolStripMenuItem.Enabled = true;
                testToolStripMenuItem1.Enabled = true;
                housekeepingToolStripMenuItem.Enabled = true;
                administrasiToolStripMenuItem.Enabled = true;
                closeToolStripMenuItem.Enabled = true;

            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guestReceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuestR guestRForm = new GuestR();
            guestRForm.WindowState = FormWindowState.Maximized; 
            guestRForm.MdiParent = this;
            guestRForm.Show();
        }

        private void roomReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomReserv RoomR = new RoomReserv();
            RoomR.WindowState = FormWindowState.Maximized;
            RoomR.MdiParent = this;
            RoomR.Show();
        }

        private void guestCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuestCheckout guestCheckout = new GuestCheckout();
            guestCheckout.WindowState = FormWindowState.Maximized;
            guestCheckout.MdiParent = this;
            guestCheckout.Show();
        }

        private void guestPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuestPay guestPay = new GuestPay();
            guestPay.WindowState = FormWindowState.Maximized;
            guestPay.MdiParent = this;
            guestPay.Show();
        }

        private void pemesananDanPenyediaanPerlengkapanKebersihanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InptDatBrngKeber PemesKeber = new InptDatBrngKeber();
            PemesKeber.WindowState = FormWindowState.Maximized;
            PemesKeber.MdiParent = this;
            PemesKeber.Show();
        }

        private void sistemInventarisasiBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvBrng InvB = new InvBrng();
            InvB.WindowState = FormWindowState.Maximized;
            InvB.MdiParent = this;
            InvB.Show();
        }

        private void pemeliharaanStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PemStok PStok = new PemStok();
            PStok.WindowState = FormWindowState.Maximized;
            PStok.MdiParent = this;
            PStok.Show();
        }

        private void ketersediaanBarangKebersihanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KetersediaanKebersihan KeterKeber = new KetersediaanKebersihan();
            KeterKeber.WindowState = FormWindowState.Maximized;
            KeterKeber.MdiParent = this;
            KeterKeber.Show();
        }

        private void pengelolaanDataKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PengDK PengD = new PengDK();
            PengD.MdiParent = this;
            PengD.Show();
        }

        private void sistemPenggajianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SisPeng SisP = new SisPeng();
            SisP.WindowState = FormWindowState.Maximized;
            SisP.MdiParent = this;
            SisP.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exportDataResepsionisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportDataInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportDataHousekeepingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportDataAdministrasiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportAllDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
