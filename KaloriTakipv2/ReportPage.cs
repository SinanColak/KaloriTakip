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
    public partial class ReportPage : Form
    {
        public ReportPage()
        {
            InitializeComponent();
        }

        private void btnGunSonuRapor_Click(object sender, EventArgs e)
        {
            btnGunSonuRapor.BackColor = Color.Black;
            btnGunSonuRapor.ForeColor = Color.White;
            btnKiyasRapor.BackColor = Color.White;
            btnKiyasRapor.ForeColor = Color.Black;
            btnYemekCesidi.BackColor = Color.White;
            btnYemekCesidi.ForeColor = Color.Black;
            pGunSonu.Visible = true;
            pKiyas.Visible = false;
            pYemekCesidi.Visible = false;
        }

        private void btnKiyasRapor_Click(object sender, EventArgs e)
        {
            btnGunSonuRapor.BackColor = Color.White;
            btnGunSonuRapor.ForeColor = Color.Black;
            btnKiyasRapor.BackColor = Color.Black;
            btnKiyasRapor.ForeColor = Color.White;
            btnYemekCesidi.BackColor = Color.White;
            btnYemekCesidi.ForeColor = Color.Black;
            pGunSonu.Visible = false;
            pKiyas.Visible = true;
            pYemekCesidi.Visible = false;
        }

        private void btnYemekCesidi_Click(object sender, EventArgs e)
        {
            btnGunSonuRapor.BackColor = Color.White;
            btnGunSonuRapor.ForeColor = Color.Black;
            btnKiyasRapor.BackColor = Color.White;
            btnKiyasRapor.ForeColor = Color.Black;
            btnYemekCesidi.BackColor = Color.Black;
            btnYemekCesidi.ForeColor = Color.White;
            pGunSonu.Visible = false;
            pKiyas.Visible = false;
            pYemekCesidi.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();

            mp.Show();
            this.Hide();
        }
    }
}
