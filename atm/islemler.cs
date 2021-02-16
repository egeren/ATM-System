using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class islemler : Form
    {
        islemler panel;
        public islemler()
        {
            InitializeComponent();
            panel = this;
            hosgeldinTxt.Text = "Hoşgeldiniz Sayın " + musteri.ad + " " + musteri.soyad;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paraCekmeBtn_Click(object sender, EventArgs e)
        {
            paraCekme paraCekmePanel = new paraCekme(panel);
            paraCekmePanel.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            borcOdeme borcPanel = new borcOdeme(panel);
            borcPanel.Show();
            this.Hide();
        }

        private void limitTanimlamaBtn_Click(object sender, EventArgs e)
        {
            limitTanimlama limitPanel = new limitTanimlama(panel);
            limitPanel.Show();
            this.Hide();
        }

        private void sifreDegistirmeBtn_Click(object sender, EventArgs e)
        {
            sifreDegistirme sifrePanel = new sifreDegistirme(panel);
            sifrePanel.Show();
            this.Hide();
        }

        private void bakiyeSorgulamaBtn_Click(object sender, EventArgs e)
        {
            bakiyeSorgulama bakiyePanel = new bakiyeSorgulama(panel);
            bakiyePanel.Show();
            this.Hide();
        }

        private void paraYatirBtn_Click(object sender, EventArgs e)
        {
            paraYatir paraYatirPanel = new paraYatir(panel);
            paraYatirPanel.Show();
            this.Hide();
        }
    }
}
