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
    public partial class bakiyeSorgulama : Form
    {
        islemler panel;
        public bakiyeSorgulama(islemler panel)
        {
            InitializeComponent();
            this.panel = panel;
            bakiyeLbl.Text = musteri.bakiye + " TL";
           
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            panel.Show();
            this.Dispose();
        }
    }
}
