using App_Framework;
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
            Fomr_EditarLaptop f1 = new Fomr_EditarLaptop();
            f1.ShowDialog();
        }

        private void btn_nuevaLaptop_Click(object sender, EventArgs e)
        {
            Form_NewComputer f2 = new Form_NewComputer();
            f2.ShowDialog();

        }
    }
}
