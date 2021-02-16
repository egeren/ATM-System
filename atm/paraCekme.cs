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
    public partial class paraCekme : Form
    {
        SqlConnection baglanti = girisForm.baglanti;
        SqlCommand komut;
        SqlDataReader reader;
        islemler panel;
        public paraCekme(islemler panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                float miktar = float.Parse(miktarTxt.Text);
                if(miktar < 1)
                {
                    MessageBox.Show("Lütfen geçerli bir miktar giriniz.");
                }
                else
                {
                    if(miktar <= musteri.bakiye)
                    {
                        musteri.bakiye -= miktar;
                        baglanti.Open();
                        komut = new SqlCommand("update musteri set bakiye="+musteri.bakiye+" where musteriID="+musteri.id, baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Para başarıyla çekildi.");
                    }
                    else if(((musteri.bakiye+musteri.limit)-musteri.borc) >= miktar)
                    {
                        miktar = miktar - musteri.bakiye;
                        musteri.bakiye = 0;
                        musteri.borc += miktar;
                        baglanti.Open();
                        komut = new SqlCommand("update musteri set bakiye=" + musteri.bakiye + ", borc="+musteri.borc+" where musteriID=" + musteri.id, baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Para ek hesap kullanılarak başarıyla çekildi.");
                    }
                    else
                    {
                        MessageBox.Show("Limitiniz yetersiz.");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen geçerli bir miktar giriniz.");
            }
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            panel.Show();
            this.Dispose();
        }
    }
}
