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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();

        }

        private void AdminPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yemekBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pYemekIslemleri.Visible = true;
            pBaslik.Visible = false;
            pKullaniciBilgileri.Visible = false;

            
        }

        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pKullaniciBilgileri.Visible = true;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pYemekIslemleri.Visible = false;
            pBaslik.Visible = true;
            pKullaniciBilgileri.Visible = true;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {
            btnYemekEkle.BackColor = Color.Black;
            btnYemekEkle.ForeColor = Color.White;
            btnYemekGuncelle.BackColor = Color.White;
            btnYemekGuncelle.ForeColor = Color.Black;
            pYemekEkle.Visible = true;
            pYemekGuncelle.Visible = false;
        }

        private void btnYemekGuncelle_Click(object sender, EventArgs e)
        {
            btnYemekEkle.BackColor = Color.White;
            btnYemekEkle.ForeColor = Color.Black;
            btnYemekGuncelle.BackColor = Color.Black;
            btnYemekGuncelle.ForeColor = Color.White;
            pYemekEkle.Visible = false;
            pYemekGuncelle.Visible = true;
        }
    }
}
