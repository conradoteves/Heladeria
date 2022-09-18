using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heladeria.Clases;
using System.Data;


namespace Heladeria.Clases
{
     class ComboBox01 : ComboBox
    {
        public string Pp_Pk { get; set; }
        public string Pp_descripcion { get; set; }

        public string Pp_tabla { get; set; }

        public bool Pp_ConSeleccion { get; set; }
        public string Pp_MensajeError { get; set; }

        Be_acceso_datos _BD = new Be_acceso_datos();

        public void CargarCombo()
        {
            string sql = "SELECT " + Pp_Pk + ", " + Pp_descripcion + " FROM " + Pp_tabla;

            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_Pk;
            this.DataSource = _BD.EjecutarSQL(sql);
            if (this.Pp_ConSeleccion == true)
            {
                this.SelectedIndex = 0;
            }
            else 
            {
                this.SelectedIndex = -1; 
            }
        }
    }
}
