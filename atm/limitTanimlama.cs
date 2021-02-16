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
    public partial class limitTanimlama : Form
    {
        SqlConnection baglanti = girisForm.baglanti;
        SqlCommand komut;
        SqlDataReader reader;
        float maksLimit;
        islemler panel;
        public limitTanimlama(islemler panel)
        {
            InitializeComponent();
            this.panel = panel;
            bilgiGuncelle();
        }


        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            panel.Show();
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                float miktar = float.Parse(miktarTxt.Text);

                if(miktar > maksLimit)
                {
                    MessageBox.Show("Maksimum limitten büyük bir değer girdiniz.");
                }
                else if(miktar < 1)
                {
                    MessageBox.Show("Lütfen sıfırdan büyük bir miktar giriniz.");
                }
                else if(miktar == musteri.limit)
                {
                    MessageBox.Show("Lütfen eski limitinizden farklı bir limit giriniz.");
                }
                else
                {
                    musteri.limit = miktar;
                    baglanti.Open();
                    komut = new SqlCommand("update musteri set musteriLimit="+musteri.limit+" where musteriID="+musteri.id, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Limitiniz başarıyla güncellendi.");
                    bilgiGuncelle();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz." + ex);
            }
        }

        void bilgiGuncelle()
        {
            
            if (musteri.limit > (musteri.bakiye + 2000))
            {
                maksLimit = musteri.limit;
            }
            else
            {
                maksLimit = musteri.bakiye + 2000;
            }
            limitLbl.Text = musteri.limit + " TL";
            maksLimitLbl.Text = maksLimit + " TL";
        }
    }
}
