using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Heladeria
{
    public class Be_acceso_datos
    {
        SqlConnection conexion = new SqlConnection(); 
        SqlCommand cmd = new SqlCommand();
        string cadena_conexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K6G05_2022;User ID=BD3K6G05_2022;Password=BDG05_8790";
        
        private void conectar() 
        {
            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;

        }

        private void desconectar() 
        {
            conexion.Close();
        }

        public DataTable EjecutarSQL(string comando) 
        {
            conectar();
            cmd.CommandText = comando;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            desconectar();
            return dt;
        }

        public void Insertar(string SqlInsertar)
        {
            conectar();
            cmd.CommandText = SqlInsertar;
            cmd.ExecuteNonQuery();
            desconectar();
        }
    }


}
