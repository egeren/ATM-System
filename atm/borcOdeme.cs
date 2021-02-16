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
    public partial class borcOdeme : Form
    {
        SqlConnection baglanti = girisForm.baglanti;
        SqlCommand komut;
        SqlDataReader reader;
        islemler panel;
        public borcOdeme(islemler panel)
        {
            InitializeComponent();
            this.panel = panel;
            bilgiGuncelle();
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            panel.Show();
            this.Dispose();
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                float miktar = float.Parse(miktarTxt.Text);
                if(miktar > musteri.borc)
                {
                    MessageBox.Show("Bu kadar miktarda borcunuz bulunmamaktadır.");
                }
                else if(miktar < 1)
                {
                    MessageBox.Show("Lütfen sıfırdan büyük bir değer giriniz.");
                }
                else if(miktar > musteri.bakiye)
                {
                    MessageBox.Show("Bakiye yetersiz.");
                }
                else
                {
                    musteri.borc -= miktar;
                    musteri.bakiye -= miktar;
                    baglanti.Open();
                    komut = new SqlCommand("update musteri set borc="+ musteri.borc +" where musteriID="+ musteri.id, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Borç başarıyla ödendi. \n Kalan borç: " + musteri.borc + " TL");
                    bilgiGuncelle();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Geçerli bir miktar giriniz.");
            }
        }

        void bilgiGuncelle()
        {
            bakiyeLbl.Text = "Bakiyeniz: " + musteri.bakiye + " TL";
            borcLbl.Text = "Borcunuz: " + musteri.borc + " TL";
        }
    }
}
