using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Framework
{
    public partial class Form_NewComputer : Form
    {
        public Form_NewComputer()
        {
            InitializeComponent();
        }

        private void Form_NewComputer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_newModel_NewComputer xnewmodel = new Form_newModel_NewComputer();
            xnewmodel.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_NewSO_NewComputer xnewsystem = new Form_NewSO_NewComputer();
            xnewsystem.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_newProcessor_NewComputer xnewprocessor = new Form_newProcessor_NewComputer();
            xnewprocessor.ShowDialog();
        }
    }
}
