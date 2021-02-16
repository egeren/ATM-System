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
    public partial class paraYatir : Form
    {
        SqlConnection baglanti = girisForm.baglanti;
        SqlCommand komut;
        SqlDataReader reader;
        islemler panel;
        public paraYatir(islemler panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            panel.Show();
            this.Dispose();
        }

        private void kendiHesabaBtn_Click(object sender, EventArgs e)
        {
            kendiButtonBtn.Show();
            kendiLbl.Show();
            kendiMiktarTxt.Show();
            kendiParaYatirBtn.Show();
            geriBtn.Show();
            baskaHesabaBtn.Hide();
            kendiHesabaBtn.Hide();
            kendiLbl.BringToFront();
            kendiMiktarTxt.BringToFront();
        }

        private void baskaHesabaBtn_Click(object sender, EventArgs e)
        {
            baskaButtonBtn.Show();
            baskaButtonBtn2.Show();
            baskaLabel2.Show();
            baskaLbl.Show();
            baskaMiktarTxt.Show();
            hesapNoTxt.Show();
            geriBtn.Show();
            baskaParaYatirBtn.Show();
            baskaLabel2.BringToFront();
            baskaLbl.BringToFront();
            baskaHesabaBtn.Hide();
            kendiHesabaBtn.Hide();
            hesapNoTxt.BringToFront();
            baskaMiktarTxt.BringToFront();

        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            kendiButtonBtn.Hide();
            kendiLbl.Hide();
            kendiMiktarTxt.Hide();
            baskaParaYatirBtn.Hide();
            baskaButtonBtn.Hide();
            baskaButtonBtn2.Hide();
            baskaLabel2.Hide();
            baskaLbl.Hide();
            baskaMiktarTxt.Hide();
            hesapNoTxt.Hide();
            geriBtn.Hide();
            kendiParaYatirBtn.Hide();
            baskaHesabaBtn.Show();
            kendiHesabaBtn.Show();
        }

        private void kendiParaYatirBtn_Click(object sender, EventArgs e)
        {
            try
            {
                float miktar = float.Parse(kendiMiktarTxt.Text);
                if(miktar < 1)
                {
                    MessageBox.Show("Lütfen sıfırdan büyük bir miktar giriniz.");
                }
                else
                {
                    musteri.bakiye += miktar;
                    baglanti.Open();
                    komut = new SqlCommand("update musteri set bakiye="+musteri.bakiye+" where musteriID="+ musteri.id, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Para başarıyla yatırıldı. \n Yeni bakiyeniz: "+ musteri.bakiye);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen geçerli bir miktar giriniz.");
            }
        }

        private void baskaParaYatirBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int hesapNo = int.Parse(hesapNoTxt.Text);
                float miktar = float.Parse(baskaMiktarTxt.Text);

                if(miktar < 1)
                {
                    MessageBox.Show("Sıfırdan büyük bir değer giriniz.");
                }
                else if(miktar > musteri.bakiye)
                {
                    MessageBox.Show("Girilen miktar, bakiyenizden büyüktür.");
                }
                else if(hesapNo == musteri.id)
                {
                    MessageBox.Show("Kendinize para transferi gerçekleştiremezsiniz.");
                }
                else
                {
                    baglanti.Open();
                    komut = new SqlCommand("select * from musteri where musteriID="+hesapNo, baglanti);
                    reader = komut.ExecuteReader();
                    if(reader.HasRows)
                    {
                        reader.Close();
                        musteri.bakiye -= miktar;
                        komut = new SqlCommand("update musteri set bakiye=(select bakiye from musteri where musteriID='"+hesapNo+"')+"+miktar+" where musteriID='"+hesapNo+"'", baglanti);
                        komut.ExecuteNonQuery();
                        komut = new SqlCommand("update musteri set bakiye="+musteri.bakiye+" where musteriID="+musteri.id, baglanti);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Para transferi başarıyla gerçekleşti.");
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir hesap bulunamadı.");
                    }
                    reader.Close();
                    baglanti.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz. " + ex);
            }
        }
    }
}
