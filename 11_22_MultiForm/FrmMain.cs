using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_22_MultiForm
{
    
    public partial class FrmMain : Form
    {
        //valtozo az ablaknak
        //public h lássa a masik
        public bool vanMarAblak = false;

        public FrmMain()
        {
            InitializeComponent();
            
        }

        private void Bt_1_Click(object sender, EventArgs e)
        {
            //...
            if (!vanMarAblak)
            {

                var frm = new FrmMasikAblak(tb_1.Text, this);
                //show or showDialog
                frm.Show();
                //..
                vanMarAblak = true;
            }

            
        }
    }
}
