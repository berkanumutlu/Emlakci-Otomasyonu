using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Emlakci
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void buttonyenievekle_Click(object sender, EventArgs e)
        {
            KayitEkrani ke = new KayitEkrani();
            ke.ShowDialog();
        }

        private void buttonsorgu_Click(object sender, EventArgs e)
        {
            SorguEkrani se = new SorguEkrani();
            se.ShowDialog();
        }
    }
}
