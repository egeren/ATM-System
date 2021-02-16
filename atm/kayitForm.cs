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
    public partial class kayitForm : Form
    {
        SqlConnection baglanti = girisForm.baglanti;
        SqlCommand komut;   
        SqlDataReader reader;
        public kayitForm()
        {
            InitializeComponent();
        }

        private void kayitForm_Load(object sender, EventArgs e)
        {
        }

        private void kayitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            if(adTxt.Text.Replace(" ", "").Length != 0 && soyadTxt.Text.Replace(" ", "").Length != 0 && tcTxt.Text.Replace(" ", "").Length != 0 && sifreTxt.Text.Length != 0 && telefonTxt.Text.Replace(" ", "").Length != 0)
            {

                baglanti.Open();
                komut = new SqlCommand("select * from musteri where musteriTc="+tcTxt.Text, baglanti);
                reader = komut.ExecuteReader();
                if(reader.HasRows)
                {
                    MessageBox.Show("Böyle bir kullanıcı var");
                }
                else
                {
                    reader.Close();
                    string ad = adTxt.Text;
                    string soyad = soyadTxt.Text;
                    string tc = tcTxt.Text;
                    string sifre = sifreTxt.Text;
                    string tel = telefonTxt.Text.Replace("(" , "").Replace(")", "").Replace(" ", "");
                    komut = new SqlCommand("insert into musteri(musteriAdi,musteriSoyad,musteriTc,musteriSifre,telno) values (@ad,@soyad,@tc,@sifre,@telno)", baglanti);
                    komut.Parameters.AddWithValue("@ad", ad);
                    komut.Parameters.AddWithValue("@soyad", soyad);
                    komut.Parameters.AddWithValue("@tc", tc);
                    komut.Parameters.AddWithValue("@sifre", sifre);
                    komut.Parameters.AddWithValue("@telno", tel);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla kayıt olundu.");
                    reader.Close();
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen alanları doldurunuz.");
            }
        }
    }
}
