using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Heladeria.Negocio
{
    internal class Ne_usuario
    {

        public enum Respuesta {aceptado , denegado }
        public Be_acceso_datos _BD = new Be_acceso_datos();
        public string Pp_apellido { get; set; }
        public string Pp_Cuil { get; set; }
        public string Pp_email { get; set; }
        public string Pp_estado { get; set; }
        public string Pp_nombres { get; set; }
        public string Pp_id_usuario { get; set; }
        public string Pp_password { get; set; }
        public string Pp_id_perfil { get; set; }

        public Respuesta ValidarLogin(string nombre, string password) 
        {
            string sql = @"SELECT * FROM Usuarios 
                            WHERE nombre = '" + nombre + "'"
                        + " AND password = '" + password + "'";

            if (_BD.EjecutarSQL(sql).Rows.Count == 0)
                return Respuesta.denegado;
            else
                return Respuesta.aceptado;
        }

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT u.*, p.nombre as n_perfil "
            + " FROM Usuarios u join Perfiles p "
            + " on u.id_perfil = p.id_perfil ";
            return _BD.EjecutarSQL(sql);
        }
        public DataTable Recuperar_x_Perfiles(string id_perfil)
        {
            string sql = @"SELECT u.*, p.nombre as n_perfil "
            + " FROM Usuarios u join Perfiles p "
            + " on u.id_perfil = p.id_perfil "
            + " WHERE u.id_perfil = " + id_perfil;
            return _BD.EjecutarSQL(sql);
        }
        public DataTable Recuprar_x_Patron(string patron)
        {
            string sql = @"SELECT u.*, p.nombre as n_perfil "
            + " FROM Usuarios u join Perfiles p "
            + " on u.id_perfil = p.id_perfil "
            + " WHERE u.nombre like '%" + patron.Trim() + "%'";
            return _BD.EjecutarSQL(sql);
        }
        public DataTable Recuperar_Mixto(string patron, string id_perfil)
        {
            string sql = @"SELECT u.*, p.nombre as n_perfil "
            + " FROM Usuarios u join Perfiles p "
            + " on u.id_perfil = p.id_perfil "
            + " WHERE u.nombre like '%" + patron.Trim() + "%'"
            + "AND u.id_perfil = " + id_perfil;
            return _BD.EjecutarSQL(sql);
        }

        public string Ultimo_Numero_Id_Usuario()
        {
            string sql = @"SELECT * FROM Usuarios";                                                
            DataTable dt = _BD.EjecutarSQL(sql);
            return Convert.ToString(dt.Rows.Count + 1);
            
        }

        public void Insertar() 
        {
            try
            {
                string sqlInsertar = @"INSERT INTO Usuarios (id_usuario,password,nombre,apellido,id_perfil,email,CUIL,id_estado)"
                                + "VALUES(" + Pp_id_usuario + ",'" + Pp_password + "'" + ",'" + Pp_nombres + "'" + ",'" + Pp_apellido + "'" + ",'" + Pp_id_perfil + "'" + ",'" + Pp_email + "'" + ",'" + Pp_Cuil + "'" + ",'" + Pp_estado + "'"
                                + ")";


                _BD.Insertar(sqlInsertar);

                MessageBox.Show("El Id_Usuario " + Pp_id_usuario + " se ha cargado exitosamente en la base de datos");

            }
            catch (Exception)
            {

                MessageBox.Show("Error al ingresar usuario!");
            }
           
            

        }
    }
}
