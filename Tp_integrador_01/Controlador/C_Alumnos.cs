using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_integrador_01.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tp_integrador_01.Controlador
{

    public class C_Alumnos
    {

        public void insertarAlumnos(string apellido, string nombre, string dni, string telefono, string direccion, string email, string localidad)
        {
            M_Alumnos alumno = new M_Alumnos(apellido, nombre, dni, telefono, direccion, email, localidad);
            if (localidad == "Seleccione su localidad..")
            {
                MessageBox.Show("Ingrese una localidad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                almacenarBD.AlmacenarAlumno(alumno);
                MessageBox.Show("Se registro correctamente a " + nombre + " en el sistema.");
            }




        }
        public List<M_Alumnos> ObtenerAlumnos()
        {
            List<M_Alumnos> listaAlumnos = new List<M_Alumnos>();

            // Obtiene una nueva conexion usando nuestro singleton
            MySqlConnection conn = M_Conexion.getInstancia().CrearConexion();

            //solicitamos los datos de la BD (subconsulta para traer la localidad en base a la id_localidad)
            string query = "SELECT socios.apellido, socios.nombre, socios.dni, socios.telefono, socios.direccion, socios.email, " +
               "(SELECT nombre_localidad FROM localidad WHERE localidad.id_localidad = socios.id_localidad) AS nombre_localidad " +
               "FROM socios";

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(query, conn);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    // Creamos un objeto M_Alumnos por cada registro y los añadimos a la lista
                    M_Alumnos alumno = new M_Alumnos(
                        reader["apellido"].ToString(),
                        reader["nombre"].ToString(),
                        reader["dni"].ToString(),
                        reader["telefono"].ToString(),
                        reader["direccion"].ToString(),
                        reader["email"].ToString(),
                        reader["nombre_localidad"].ToString()
                    );
                    listaAlumnos.Add(alumno);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Maneja excepciones para evitar cierres por errores de conexion
                Console.WriteLine("Error al obtener los datos: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return listaAlumnos;
        }

        //Metodo que vamos a usar para cargar los alumnos en el comboBox

        public void CargarNombresComboBox(ComboBox comboBoxAlumnos)
        {
            List<M_Alumnos> listaAlumnos = ObtenerAlumnos();

            foreach (M_Alumnos alumno in listaAlumnos)
            {
                comboBoxAlumnos.Items.Add(alumno.Apellido);
            }
        }


        public static void EliminarAlumno(int index)
        {


        }







    }
}
