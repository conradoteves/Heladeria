using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Heladeria.Clases;

namespace Heladeria.Clases
{
    class TratamientoEspeciales
    {
        public enum Resultado { correcto, error }

        public Resultado Validar(Control.ControlCollection controles)
        {
           foreach (var item in controles)
            {
                //MessageBox.Show((item.GetType().Name));

                if ((item.GetType().Name) =="GroupBox") 
                {
                    foreach (var item1 in ((GroupBox)item).Controls)
                    {
                        //MessageBox.Show((item1.GetType().Name));

                        if (item1.GetType().Name == "TextBox01")
                        {
                            if (((TextBox01)item1).Text == "")
                            {
                                MessageBox.Show(((TextBox01)item1).Pp_mensaje_error);
                                ((TextBox01)item1).Focus();
                                return Resultado.error;

                            }

                        }
                        if (item1.GetType().Name == "ComboBox01")
                        {
                            if (((ComboBox01)item1).SelectedIndex == -1)
                            {
                                MessageBox.Show(((ComboBox01)item1).Pp_MensajeError);
                                ((ComboBox01)item1).Focus();
                                return Resultado.error;

                            }

                        }

                    }
                }

                  
            }

            return Resultado.correcto;

        }
    }
}
