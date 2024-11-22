using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_integrador_01.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;



/* // ?Ejemplo para isnertar un alumno con los datos basicos, luego tomar el id asignado e ingresar su telefono
en otra tabla:

-- Insertar un nuevo socio
INSERT INTO SOCIOS (nombre, apellido) VALUES ('Juan', 'Pérez');

-- Obtener el ID del socio insertado
SET @id_socio = LAST_INSERT_ID();

-- Insertar el teléfono asociado al socio
INSERT INTO TELEFONOS (id_socio, numero_telefono) VALUES (@id_socio, '123456789');

*/

namespace Tp_integrador_01.Controlador
{

    public class C_Alumnos
    {


        //--------------------metodo para insertar alumno en la BD (socio)-----------------
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

        //--------------------metodo para obtener alumnos de la BD (para mostrar en el datagrid)-----------------
        public List<M_Alumnos> ObtenerAlumnos()
        {
            List<M_Alumnos> listaAlumnos = new List<M_Alumnos>();

            // Obtiene una nueva conexion usando nuestro singleton
            MySqlConnection conn = M_Conexion.getInstancia().CrearConexion();

            //solicitamos los datos de la BD (subconsulta para traer la localidad en base a la id_localidad)
            string query = "SELECT socios.id_socio, socios.apellido, socios.nombre, socios.dni, socios.telefono, socios.direccion, socios.email, " +
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

                        Convert.ToInt32(reader["id_socio"]),
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


        //--------------------metodo para cargar los alumnos en el comboBox-----------------
        public void CargarNombresComboBox(ComboBox comboBoxAlumnos)
        {
            List<M_Alumnos> listaAlumnos = ObtenerAlumnos();

            foreach (M_Alumnos alumno in listaAlumnos)
            {
                comboBoxAlumnos.Items.Add(alumno.Id_socio + " " + alumno.Apellido );
            }
        }




        //--------------------metodo para eliminar alumno de la BD-----------------
        public static void EliminarAlumno(int dni)
        {
            var SqlCon = new MySqlConnection();
            try
            {
                SqlCon = M_Conexion.getInstancia().CrearConexion();
                string sql_tarea = "DELETE FROM socios WHERE dni = " + dni;

                var Comando = new MySqlCommand(sql_tarea, SqlCon);

                SqlCon.Open();
                Comando.ExecuteNonQuery();

                //mensaje de debug 
                MessageBox.Show("Se elimino correctamente el socio con dni: " + dni);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }

            }

        }

    }
}
