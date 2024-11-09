using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tp_integrador_01.Modelo
{


    internal class M_Alumnos
    {


        //test


        public string insertarAlumnosBD(string apellido, string nombre, string dni, string telefono, string direccion, string email, int localidad)
        {
            string respuesta = "";
            var SqlConexion = new MySqlConnection();

            try{
                String Query = "INSERT INTO socios(direccion, nombre, apellido, email, localidad ,dni) values(" + direccion + "," + nombre + "," + apellido + "," + email + "," + localidad + "," + dni + ")";

                SqlConexion = M_Conexion.getInstancia().CrearConexion();

                var Comando = new MySqlCommand(Query, SqlConexion);
                SqlConexion.Open();
                respuesta = Comando.ExecuteNonQuery() >= 1 ? "se inserto correctamente el registro" : "No se pudo insertar el registro.";

            }
            catch (Exception ex){
                respuesta = ex.Message;
            }
            finally{
                if (SqlConexion.State == ConnectionState.Open){
                    SqlConexion.Close();
                }
            }
            return respuesta;

        }


    }
}
