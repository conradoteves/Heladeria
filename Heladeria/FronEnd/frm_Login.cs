using Heladeria.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria.FronEnd
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "") 
            {
                MessageBox.Show("El usuario esta vacio");
                txt_Nombre.Focus();
                return;

            }
            if (txt_Contraseña.Text == "") 
            {
                MessageBox.Show("La contraseña esta vacia");
                txt_Contraseña.Focus();
                return ;
            }
            Ne_usuario usuario = new Ne_usuario();

            if (usuario.ValidarLogin(txt_Nombre.Text, txt_Contraseña.Text) == Ne_usuario.Respuesta.aceptado)
            {
                MessageBox.Show("Bienvenido al sistema has ingresado!");
                this.Close();
            }
            else
            {
                txt_Nombre.Text = "";
                txt_Contraseña.Text = "";
                MessageBox.Show("Este usuario y password no exiten");
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
