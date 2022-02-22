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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            pPage2.Visible = false;
            pPage3.Visible = true;
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            pPage1.Visible = false;
            pPage2.Visible = true;
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            pPage3.Visible = false;
            pLogin.Visible = true;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            btnKayit.BackColor = Color.LightBlue;
            btnGiris.BackColor = Color.Transparent;
            pKayit.Visible = true;
            pGiris.Visible = false;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.LightBlue;
            btnKayit.BackColor = Color.Transparent;
            pKayit.Visible = false;
            pGiris.Visible = true;

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtGSifre.Text == "admin")
            {
                AdminPage ap = new AdminPage();
                ap.Show();
                this.Hide();
            }
            else
            {
                MainPage mp = new MainPage();
                mp.Show();
                this.Hide();
            }
            
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            
        }
    }
}
