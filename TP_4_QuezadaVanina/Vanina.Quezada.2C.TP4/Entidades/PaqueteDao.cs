using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PaqueteDao
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static string connectionString;
        static PaqueteDao()
        {
             connectionString = @"Server = .\SQLEXPRESS; Database= correo-sp-2017; Trusted_Connection = true;";
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static bool Insertar(Paquete p)
        {
            bool respuesta = false;
            try
            { 
                using (conexion)
                {
                    string command = "INSERT INTO  Paquetes (direccionEntrega,trackingID,alumno) " +
                    "VALUES(@direccion,@tracking, @alumno)";
                    comando.CommandText = command;
                    conexion.ConnectionString = connectionString;
                    comando.Parameters.AddWithValue("@direccion", p.DireccionEntrega);
                    comando.Parameters.AddWithValue("@tracking", p.TrackingID);
                    comando.Parameters.AddWithValue("@alumno", "Vanina Quezada");

                    conexion.Open();
                   
                    comando.ExecuteNonQuery();

                    respuesta = true;
                    comando.Parameters.Clear();

                }

            }
            catch(Exception)
            {
               throw new Exception("Error al cargar datos en la base de datos");
                
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return respuesta;
        }
    }
}
