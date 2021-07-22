using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class Form_Computer : Form
    {
        public Form_Computer()
        {
            InitializeComponent();
        }

        private void btn_modificarlaptop_Click(object sender, EventArgs e)
        {
            Fomr_EditarLaptop f2 = new Fomr_EditarLaptop();
            f2.ShowDialog();
        }

        private void btn_nuevaLaptop_Click(object sender, EventArgs e)
        {

        }
    }
}
