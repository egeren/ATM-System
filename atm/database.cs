using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace atm
{
    public class database
    {
        string con;
        public SqlConnection baglanti;
        public SqlCommand komut;
        public SqlDataReader reader;
        

        public void baglan()
        {
            try
            {
                con = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=projedb;Integrated Security=True;Connect Timeout=0;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                baglanti = new SqlConnection(con);
                komut = new SqlCommand();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
