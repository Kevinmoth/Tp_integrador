using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Tp_integrador_01.Controlador;
using Tp_integrador_01.Modelo;

namespace PJ_conexionIntegrador.Controlador
{
    class C_Prestamos
    {

     //                                     METODOS CARGAR TABLAS

        //----------------------Metodo para mostrar el listado de prestamos-----------------------
        public static DataTable ListadoPrestamos()
        {
            MySqlDataReader dataReader;
            var sqlCon = new MySqlConnection();
            var tabla = new DataTable();
            string consulta;

            sqlCon = M_Conexion.getInstancia().CrearConexion();
            sqlCon.Open();
            consulta = "SELECT prestamos.`id_prestamo`, prestamos.`fecha_prestamo`,prestamos.`fecha_devolucion`," +
                        "prestamos.`fecha_real_devolucion`,(SOCIOS.`apellido`) as socios, LIBROS.`titulo`, (bibliotecarios.`apellido`) as bibliotecario," +
                        "prestamos.`id_copialibros` " +
                        "FROM prestamos " +
                        "INNER JOIN socios " +
                        "ON prestamos.`id_socio` = socios.`id_socio` " +
                        "INNER JOIN bibliotecarios " +
                        "ON prestamos.`id_bibliotecario` = bibliotecarios.`id_bibliotecario` " +
                        "INNER JOIN libros " +
                        "ON prestamos.`id_libro` = libros.`id_libro`";

            var comando = new MySqlCommand(consulta, sqlCon);
            dataReader = comando.ExecuteReader();
            tabla.Load(dataReader);  // Cargar los resultados en la tabla

            return tabla;
        }

        //----------------------Metodo para cargar los libros en el combobox-------------------------

        public static DataTable ListadoSuspensiones()
        {

            MySqlDataReader Resultado;
            var Tabla = new DataTable();
            var SqlCon = new MySqlConnection();
            try
            {
                SqlCon = M_Conexion.getInstancia().CrearConexion();
                /*
                Querry que muestra el apellido, nombre, titulo, fecha_prestamo, fecha_devolucion, fecha_real_devolucion y la id de la suspension
                */
                string query = "SELECT socios.apellido, socios.nombre, libros.titulo, prestamos.fecha_prestamo, prestamos.fecha_devolucion, prestamos.fecha_real_devolucion, suspencion.id_suspencion " + "FROM suspencion " + "INNER JOIN prestamos ON suspencion.id_prestamo = prestamos.id_prestamo " + "INNER JOIN socios ON prestamos.id_socio = socios.id_socio " + "INNER JOIN libros ON prestamos.id_libro = libros.id_libro";
                SqlCon.Open();
                MySqlCommand commando = new MySqlCommand(query, SqlCon);
                Resultado = commando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }


            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw error;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }



            }

        }

        //--------------Metodo para crear un objeto prestamo y calcular la fecha de devolucion----------------
        public static void generarPrestamo(string alumno, string libro, string bibliotecario, int id_copialibro)
        {
            // Extraer IDs (mediante Linq, separamos los dígitos del string)
            string Alumno = new string(alumno.Where(char.IsDigit).ToArray());
            string Bibliotecario = new string(bibliotecario.Where(char.IsDigit).ToArray());
            string Libro = new string(libro.Where(char.IsDigit).ToArray());
            string Id_copialibros = id_copialibro.ToString();

            // Formateamos las fechas de prestamo y devolucion para la base de datos
            string fechaPrestamo = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string fechaDevolucion = DateTime.Now.AddDays(3).ToString("yyyy-MM-dd HH:mm:ss");

            // Query para verificar si el alumno esta sancionado
            string sancion = "SELECT prestamos.id_socio " +
                                 "FROM prestamos " +
                                 "INNER JOIN suspencion ON prestamos.id_prestamo = suspencion.id_prestamo " +
                                 "WHERE prestamos.id_socio = " + Alumno + " " +
                                 "AND suspencion.id_suspencion IS NOT NULL";



            // Query para insertar un préstamo
            string querry = "INSERT INTO prestamos (id_socio, id_bibliotecario, id_libro, id_copialibros, fecha_prestamo, fecha_devolucion) " +
                            "VALUES('" + Alumno + "', '" + Bibliotecario + "', '" + Libro + "', '" + Id_copialibros + "', '" + fechaPrestamo + "', '" + fechaDevolucion + "')";

            MySqlDataReader dataReader;
            var sqlCon = M_Conexion.getInstancia().CrearConexion();
            sqlCon.Open();

            // Verificar sanciones
            MySqlCommand comando = new MySqlCommand(sancion, sqlCon);
            dataReader = comando.ExecuteReader();

            
            if (dataReader.HasRows)
            {
                MessageBox.Show("El alumno tiene un préstamo sancionado. No se puede agregar el préstamo.");
                dataReader.Close();
                sqlCon.Close();
                return;  // Sale del meetodo, no se agrega el prestamo
            }

            dataReader.Close();

            // Insertar préstamo
            comando = new MySqlCommand(querry, sqlCon);
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Préstamo registrado exitosamente.");
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Error al agregar el prestamo: " + ex.Message);
            }

            sqlCon.Close();
        }

        //---------------------Metodo para insertar un prestamo en la base de datos-------------------------

        public static string InsertarPrestamo(M_Prestamo Prestamo)
        {
            string Rpta = "";
            string sqlTarea = "";
            var SqlCon = new MySqlConnection();

            try
            {

                SqlCon = M_Conexion.getInstancia().CrearConexion();

                sqlTarea = "INSERT INTO estudiante (id_socio, " +
                                                    "id_bibliotecario, " +
                                                    "id_libro, " +
                                                    "id_copialibros, " +
                                                    "fecha_prestamo, " +
                                                    "fecha_devolucion, " +
                                                    "fecha_real_devolucion)" +
                                           "VALUES(" + Prestamo.Id_prestamo + ",'" +
                                                       Prestamo.Id_socio + "','" +
                                                       Prestamo.Id_libro + "','" +
                                                       Prestamo.Id_copialibros + "','" +
                                                       Prestamo.Fecha_prestamo + "'," +
                                                       Prestamo.Fecha_devolucion + "','" +
                                                       Prestamo.Fecha_real_devolucion + "')";
                MessageBox.Show(sqlTarea);
                var Comando = new MySqlCommand(sqlTarea, SqlCon);
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo insertar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Rpta;
        }




        //                                    METODOS PARA CARGAR DATOS EN LOS COMBOBOX

        //metodo para cargar los bibliotecarios en el combobox
        public static void CargarBibliotecarios(ComboBox comboBoxLibro)
        {
            List<M_Bibliotecarios> listaBibliotecarios = ObtenerBibliotecarios();

            foreach (M_Bibliotecarios Bibliotecario in listaBibliotecarios)
            {
                comboBoxLibro.Items.Add(Bibliotecario.Id_bibliotecario + " - " + Bibliotecario.Apellido);


            }

        }

        //----------------------Metodo para cargar los libros en el combobox-------------------------
        public DataTable CargaComboLibros()
        {
            MySqlDataReader Resultado;
            var Tabla = new DataTable();
            var SqlCon = new MySqlConnection();
            try
            {
                SqlCon = M_Conexion.getInstancia().CrearConexion();
                string sql_tarea = "select id_libro,titulo from libros order by id_libro";
                var Comando = new MySqlCommand(sql_tarea, SqlCon);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception error)
            {
                //MessageBox.Show(error.Message);
                throw error;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }

            }

        }

        /* Metodo que obtiene la id del libro seleccionado 
           por el usuario y carga los ejemplares que NO hayan 
           sido prestados en el combobox */
        public static DataTable datosComboBoxLibro(string NombreLibro)
        {
            MySqlDataReader resultado;
            var Tabla = new DataTable();
            MySqlConnection conn = M_Conexion.getInstancia().CrearConexion();

            try
            {
                conn.Open();
                // Obtenemos el nombre del libro sin el guion y el id
                int indiceGuion = NombreLibro.IndexOf(" - ");
                string nombreDelLibro = NombreLibro.Substring(indiceGuion + 3);
                


                // Obtenemos la id del libro usando el nombre a su nombre
                string query1 = "SELECT id_libro FROM libros WHERE titulo = '" + nombreDelLibro + "'";
                MySqlCommand cm1 = new MySqlCommand(query1, conn);

                var idLibro = cm1.ExecuteScalar();// ExecuteScalar lo usamos para guardar solo 1 valor

                // Consultamos y filtramos las copias disponibles
                string query2 = "SELECT id_copialibros FROM copia_libros WHERE id_libro = '" + idLibro + "' AND en_prestamo = 0";
                MySqlCommand cm2 = new MySqlCommand(query2, conn);
                resultado = cm2.ExecuteReader();
                Tabla.Load(resultado);

                // Verificamos si no hay ejemplares disponibles
                if (Tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No hay ejemplares disponibles de el libro seleccionado en este momento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return Tabla;
        }


        


        //metodo para obtener los bibliotecarios
        public static List<M_Bibliotecarios> ObtenerBibliotecarios()
        {
            List<M_Bibliotecarios> listaBibliotecarios = new List<M_Bibliotecarios>();

            MySqlConnection conn = M_Conexion.getInstancia().CrearConexion();

            string query = "SELECT id_bibliotecario, apellido FROM bibliotecarios";

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(query, conn);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    M_Bibliotecarios Bibliotecarios = new M_Bibliotecarios(int.Parse(reader["id_bibliotecario"].ToString()), reader["apellido"].ToString());
                    listaBibliotecarios.Add(Bibliotecarios);
                }
                reader.Close();
            }

            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener los datos: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return listaBibliotecarios;
        }


        


        //metodo para agregar una devolucion


        public static void agregarDevolucion(DateTime fecha_devolucion, DateTime fecha_devolucion_real, int id_prestamo)
        {
            string sql_tarea = "";
            var SqlCon = new MySqlConnection();
            SqlCon = M_Conexion.getInstancia().CrearConexion();
            /*Si el alumno devuelve el liblo antes de la fecha de devolucion 
             * ( fecha de devolucion >= fecha de devolucion real) solo se actualiza la 
             * fecha de devolucion real, sin embargo , si por el contrario, la fecha de devolucion 
             * real es mayor a la fecha de devolucion ,se inserta en la tabla suspencion, la fecha_suspencion (que es la fecha de devolucion real)
            */

            if (fecha_devolucion <= fecha_devolucion_real)
            {
                sql_tarea = "INSERT INTO suspencion (fecha_suspencion, id_prestamo) VALUES ('" + fecha_devolucion_real.ToString("yyyy-MM-dd HH:mm:ss") + "'," + id_prestamo + ") ;";
                MessageBox.Show("El alumno fue suspendido");
                
            }

            string querryFecha = "UPDATE prestamos SET fecha_real_devolucion = '" + fecha_devolucion.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id_prestamo = " + id_prestamo + ";";

            //query para habilitar el libro devuelto 
            string devuelto = "UPDATE copia_libros SET en_prestamo = 0 WHERE id_copialibros = (SELECT id_copialibros FROM prestamos WHERE id_prestamo = " + id_prestamo + ");";


            try
            {
                SqlCon.Open();
                
                MySqlCommand FechaDevolucion = new MySqlCommand(querryFecha, SqlCon);
                FechaDevolucion.ExecuteNonQuery();
                

                MySqlCommand comando = new MySqlCommand(sql_tarea, SqlCon);
                comando.ExecuteNonQuery();
                
                MySqlCommand devolucion = new MySqlCommand(devuelto, SqlCon);
                devolucion.ExecuteNonQuery();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }



        }


        



        //Metodo para quitar suspencion
        public static void quitarSuspension(int id_suspencion) {
            var SqlCon = new MySqlConnection();
            SqlCon = M_Conexion.getInstancia().CrearConexion();
            string sql_tarea = "DELETE FROM suspencion WHERE id_suspencion = " + id_suspencion + ";";
            var Comando = new MySqlCommand(sql_tarea, SqlCon);
            SqlCon.Open();
            Comando.ExecuteNonQuery();
        }

    }
}


