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
    public partial class FrmMasikAblak : Form
    {
        FrmMain FrmMainRef;
        public FrmMasikAblak(string szoveg, FrmMain foablak)
        {
            InitializeComponent();
            //DataTransfer
            FrmMainRef = foablak;
            lb_masikform.Text = szoveg;
        }

        private void Bt_masikform_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            //color picker
            FrmMainRef.BackColor = colorDialog1.Color;

        }

        private void FrmMasikAblak_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Change the variable, so you can open another window after closing
            FrmMainRef.vanMarAblak = false;
        }
    }
}
