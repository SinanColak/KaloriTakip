using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriTakipv2
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pKullaniciBilgileri.Visible = true;
            pYemekBilgileri.Visible = false;
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportPage rp = new ReportPage();
            rp.Show();
        }

        private void tsmYemekBilgileri_Click(object sender, EventArgs e)
        {
            pYemekBilgileri.Visible = true;
            pKullaniciBilgileri.Visible = false;
        }

        private void btnCorba_Click(object sender, EventArgs e)
        {
            pbYemek.Visible = true;
        }

        private void btnEt_Click(object sender, EventArgs e)
        {
            pbYemek.Visible = true;
        }

        private void btnBalik_Click(object sender, EventArgs e)
        {
            pbYemek.Visible = true;
        }

        private void btnTavuk_Click(object sender, EventArgs e)
        {
            pbYemek.Visible = true;
        }

        private void btnSebze_Click(object sender, EventArgs e)
        {
            pbYemek.Visible = true;
        }

        private void btnSalata_Click(object sender, EventArgs e)
        {
            pbYemek.Visible = true;
        }

        private void btnHamurlular_Click(object sender, EventArgs e)
        {
            pbYemek.Visible = true;
        }

        private void btnMeze_Click(object sender, EventArgs e)
        {
            pbYemek.Visible = true;
        }

        private void btnZeytinyagli_Click(object sender, EventArgs e)
        {
            pbYemek.Visible = true;
        }

        private void btnTatlilar_Click(object sender, EventArgs e)
        {
            pbYemek.Visible = true;
        }

        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            pbYemek.Visible = true;
        }

        private void btnMakarna_Click(object sender, EventArgs e)
        {
            pbYemek.Visible = true;
        }

        private void pYemekBilgileri_Paint(object sender, PaintEventArgs e)
        {
            pbYemek.Visible = false;
        }
    }
}
