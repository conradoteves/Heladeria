using Heladeria.FronEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Heladeria
{
    public partial class frm_Escritorio : Form
    {
        public frm_Escritorio()
        {
            InitializeComponent();
        }

        private void frm_Escritorio_Load(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.ShowDialog();


        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ABM_Usuario usuarios = new frm_ABM_Usuario();
            usuarios.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
