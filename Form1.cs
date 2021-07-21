using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.Sql;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace App
{
    public partial class Form_principal : Form
    {
        //SOLO PARA VISTAS

        //linea
        private IconButton currentbtn;
        private Panel bordeizquierdo;
        private Form mostrarform;
        public Form_principal()
        {
            InitializeComponent();
            bordeizquierdo = new Panel();
            bordeizquierdo.Size = new Size(7, 60);
            panel_button.Controls.Add(bordeizquierdo);
        }

        //Metodos xd 

        private void texto(String textoarriba)
        {
            lbl_actual.Text = textoarriba;
        }

        //PARA ABRIR UN FORM DENTRO DEL FORM PRINCIPAL
        private void abrirForm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel_container.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                panel_container.Controls.Add(formulario);
                panel_container.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void Reset()
        {
            botonocultar();
            bordeizquierdo.Visible = false;
            icon_IconoActual.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            icon_IconoActual.IconColor = Color.White;
            lbl_actual.Text = "Home";
        }


        private void botonmostrar(object tipoboton, Color color)
        {
            if (tipoboton != null)
            {
                botonocultar();
                currentbtn = (IconButton)tipoboton;
                currentbtn.BackColor = Color.FromArgb(52, 73, 94);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                //borde izquierdo

                bordeizquierdo.BackColor = color;
                bordeizquierdo.Location = new Point(0, currentbtn.Location.Y);
                bordeizquierdo.Visible = true;
                bordeizquierdo.BringToFront();

                //para icono y texto superior
                icon_IconoActual.IconChar = currentbtn.IconChar;
                icon_IconoActual.IconColor = Color.FromArgb(241, 196, 20);
            }
        }

        private void botonocultar()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(52, 73, 94);
                currentbtn.ForeColor = Color.White;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.White;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }

        //</SOLO PARA VISTAS> AQUI TERMINA

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //No tocar es arte xd
            botonmostrar(sender, Color.FromArgb(241, 196, 20));
            texto("Search");
            //programar aca abajo

            // abrir form hijo
            abrirForm<Form_Search>();
        }
        private void btn_editUser_Click_1(object sender, EventArgs e)
        {
            //No tocar es arte xd
            botonmostrar(sender, Color.FromArgb(241, 196, 20));
            texto("Users");
            //programar aca abajo 
            // abrir form hijo
            abrirForm<Form_Users>();

        }

        private void btn_laptops_Click(object sender, EventArgs e)
        {
            botonmostrar(sender, Color.FromArgb(241, 196, 20));
            texto("Computer");
            // abrir form hijo
            abrirForm<Form_Laptops>();

        }

        private void btn_analytics_Click_1(object sender, EventArgs e)
        {
            botonmostrar(sender, Color.FromArgb(241, 196, 20));
            texto("Analytics");
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            //Aca se podra cambiar los parametros de la conexion de DB 
            //aun no se donde colorcarlo :(
        }
    }
}
