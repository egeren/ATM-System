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
    public partial class girisForm : Form
    {

        public static SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader reader;
        
        public girisForm()
        {
            InitializeComponent();
        }
        private void girisForm_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\projedb.mdf;Integrated Security=True;");
                baglanti.Open();
                baglanti.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanına bağlanılamadı." + ex);
                this.Dispose();
            }
        }

        private void kartBtn_Click_1(object sender, EventArgs e)
        {
            kartLabel.Visible = false;
            tcLabel.Visible = true;
            sifreLabel.Visible = true;

            tcTxt.Visible = true;
            sifreTxt.Visible = true;
            
            tcBackground.Visible = true;
            sifreBackground.Visible = true;
            girisBtn.Visible = true;
            cikisBtn.Visible = true;
            kayitBtn.Visible = true;
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("select * from musteri where musteriTc='" + tcTxt.Text + "' and musteriSifre='" + sifreTxt.Text+"'", baglanti);
            reader = komut.ExecuteReader();
            if(reader.HasRows)
            {

                reader.Read();
                int id = reader.GetInt32(0);
                string ad = reader.GetString(1);
                string soyad = reader.GetString(2);
                string tc = reader.GetString(3);
                string sifre = reader.GetString(4);
                float bakiye = (float) reader.GetDouble(5);
                string tel = reader.GetString(6);
                float limit = (float) reader.GetDouble(7);
                float borc = (float) reader.GetDouble(8);
                musteri.musteriOlustur(id, ad, soyad, tc, sifre, bakiye, tel, borc, limit);
                islemler islemlerFrm = new islemler();
                islemlerFrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı.");
            }
            baglanti.Close();
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            kayitForm kayitFrm = new kayitForm();
            kayitFrm.Show(this);
            this.Hide();
        }
    }
}
