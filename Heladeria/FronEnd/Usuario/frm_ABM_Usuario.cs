using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heladeria.FronEnd;
using Heladeria.Negocio;


namespace Heladeria.FronEnd
{
    public partial class frm_ABM_Usuario : Form
    {
        public frm_ABM_Usuario()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ABM_Usuario_Load(object sender, EventArgs e)
        {
            cmb_Perfil.CargarCombo();
            cmb_Perfil.SelectedIndex = -1;
            
        }

        private void btn_3Puntos_Click(object sender, EventArgs e)
        {
            cmb_Perfil.SelectedIndex = -1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_Perfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chk_Todos_Usuarios_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
                Ne_usuario ne_Usuario = new Ne_usuario();

            if (this.chk_Todos_Usuarios.Checked == false &&
            this.txt_Patron.Text == string.Empty &&
            this.cmb_Perfil.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar alguna opción",
                "Importate", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            if (this.chk_Todos_Usuarios.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = ne_Usuario.RecuperarTodos();
                CargarGrilla(tabla);
                return;
            }
            if (this.chk_Todos_Usuarios.Checked == false
            && this.cmb_Perfil.SelectedIndex != -1
            && this.txt_Patron.Text != "")
            {
                CargarGrilla(ne_Usuario.Recuperar_Mixto(this.txt_Patron.Text,
                this.cmb_Perfil.SelectedValue.ToString()));
                return;
            }
            if (this.cmb_Perfil.SelectedIndex != -1)
            {
                CargarGrilla(ne_Usuario.Recuperar_x_Perfiles
                (this.cmb_Perfil.SelectedValue.ToString()));
                return;
            }
            if (this.txt_Patron.Text != "")
            {
                CargarGrilla(ne_Usuario.Recuprar_x_Patron(this.txt_Patron.Text));
            }
        }
        private void CargarGrilla(DataTable tabla)
        {
            this.dgr_Usuarios.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                this.dgr_Usuarios.Rows.Add();
                this.dgr_Usuarios.Rows[i].Cells[0].Value = tabla.Rows[i]["id_usuario"].ToString();
                this.dgr_Usuarios.Rows[i].Cells[1].Value = tabla.Rows[i]["password"].ToString();
                this.dgr_Usuarios.Rows[i].Cells[2].Value = tabla.Rows[i]["nombre"].ToString();
                this.dgr_Usuarios.Rows[i].Cells[3].Value = tabla.Rows[i]["apellido"].ToString();
                this.dgr_Usuarios.Rows[i].Cells[4].Value = tabla.Rows[i]["n_perfil"].ToString();
                this.dgr_Usuarios.Rows[i].Cells[5].Value = tabla.Rows[i]["email"].ToString();
                this.dgr_Usuarios.Rows[i].Cells["id_usuario"].Value = tabla.Rows[i]["id_usuario"].ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            frm_AltaUsuarios frm_Alta_Usuarios = new frm_AltaUsuarios();
            frm_Alta_Usuarios.ShowDialog();
        }
    }
}
