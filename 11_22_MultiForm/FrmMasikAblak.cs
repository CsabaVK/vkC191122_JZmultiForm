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
        public FrmMasikAblak()
        {
            InitializeComponent();
        }

        private void Bt_masikform_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
