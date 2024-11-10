using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp_integrador_01.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tp_integrador_01.Controlador
{
    
    public class C_Alumnos
    {

        public void insertarAlumnos(string apellido, string nombre, string dni, string telefono, string direccion, string email, int localidad)
        {
            M_Alumnos alumno = new M_Alumnos(apellido, nombre, dni, telefono, direccion, email, localidad);
            almacenarBD.AlmacenarAlumno(alumno);
        }
        public List<M_Alumnos> ObtenerAlumnos()
        {
            List<M_Alumnos> listaAlumnos = new List<M_Alumnos>();

            // Obtiene una nueva conexion usando nuestro singleton
            MySqlConnection conn = M_Conexion.getInstancia().CrearConexion();
            
            //solicitamos los datos de la BD
            string query = "SELECT apellido, nombre, dni, telefono, direccion, email, localidad FROM socios";

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(query, conn);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    // Creamos un objeto M_Alumnos por cada registro y añadirlo a la lista
                    M_Alumnos alumno = new M_Alumnos(
                        reader["apellido"].ToString(),
                        reader["nombre"].ToString(),
                        reader["dni"].ToString(),
                        reader["telefono"].ToString(),
                        reader["direccion"].ToString(),
                        reader["email"].ToString(),
                        int.Parse(reader["localidad"].ToString())
                    );
                    listaAlumnos.Add(alumno);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Maneja excepciones para evitar cierres pro errores de conexion
                Console.WriteLine("Error al obtener los datos: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return listaAlumnos;
        }

    }
}
