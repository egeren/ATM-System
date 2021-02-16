using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace atm
{
    public partial class sifreDegistirme : Form
    {
        SqlConnection baglanti = girisForm.baglanti;
        SqlCommand komut;
        SqlDataReader reader;
        islemler panel;
        public sifreDegistirme(islemler panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            panel.Show();
            this.Dispose();
        }

        private void sifreDegistirBtn_Click(object sender, EventArgs e)
        {
            string eski = eskiSifreTxt.Text;
            string yeni = yeniSifreTxt.Text;
            string yeniTekrar = yeniSifreTekrarTxt.Text;

            if(yeni == musteri.sifre)
            {
                MessageBox.Show("Yeni şifreniz ile eski şifreniz aynı olamaz.");
            }
            else if (yeni != yeniTekrar)
            {
                MessageBox.Show("Şifreler eşit değil.");
            }
            else if (eski != musteri.sifre)
            {
                MessageBox.Show("Eski şifrenizi yanlış girdiniz.");
            }
            else if(yeni.Length < 1)
            {
                MessageBox.Show("Lütfen şifre alanlarını doldurun.");
            }
            else
            {
                baglanti.Open();
                komut = new SqlCommand("update musteri set musteriSifre="+yeni+" where musteriID="+musteri.id, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                musteri.sifre = yeni;
                MessageBox.Show("Şifreniz başarıyla güncellendi.");
            }
        }
    }
}
