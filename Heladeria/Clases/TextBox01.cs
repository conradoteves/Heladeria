using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heladeria.Clases;

namespace Heladeria.Clases
{
    internal class TextBox01 :TextBox
    {
        public bool Pp_validable { get; set; }
        public string Pp_nombre_tabla { get; set; }
        public string Pp_nombre_campo { get; set; }
        public string Pp_mensaje_error { get; set; }       

    }
}
