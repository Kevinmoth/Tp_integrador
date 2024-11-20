using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Tp_integrador_01.Controlador;
using Tp_integrador_01.Modelo;

namespace PJ_conexionIntegrador.Controlador
{
    class C_Prestamos
    {

        //--------------Metodo para mostrar el listado de prestamos----------------
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






        //--------------Metodo para crear un objeto prestamo y calcular la fecha de devolucion----------------
        public static void generarPrestamo(string alumno, string libro, string bibliotecario, int id_copialibro)
        {
            string Alumno = alumno;
            //querry para obtener el id del socio teniendo su nombre
            string querry1 = "SELECT id_socio FROM socios WHERE apellido = '" + Alumno + "'";
            //querry para obtener el id del bibliotecario teniendo su nombre
            string querry2 = "SELECT id_bibliotecario FROM bibliotecarios WHERE apellido = '" + bibliotecario + "'";
            //querry para obtener el id del libro teniendo su nombre
            string querry3 = "SELECT id_libro FROM libros WHERE titulo = '" + libro + "'";

            MySqlDataReader dataReader;
            var sqlCon = new MySqlConnection();

            M_Prestamo prestamo = new M_Prestamo();
            sqlCon = M_Conexion.getInstancia().CrearConexion();
            sqlCon.Open();

            var comando = new MySqlCommand(querry1, sqlCon);
            dataReader = comando.ExecuteReader();
            
            prestamo.Id_copialibros = id_copialibro;
            prestamo.Fecha_prestamo = DateTime.Now;
            prestamo.Fecha_devolucion = prestamo.Fecha_prestamo.AddDays(7);

            M_Prestamo Prestamo = new M_Prestamo(prestamo.Id_prestamo, prestamo.Id_socio, prestamo.Id_bibliotecario, prestamo.Id_libro, prestamo.Id_copialibros, prestamo.Fecha_prestamo, prestamo.Fecha_devolucion, prestamo.Fecha_real_devolucion);
            //InsertarPrestamo(prestamo);
            sqlCon.Close();
        

    
    }


        //--------------Metodo para insertar un prestamo en la base de datos----------------

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
                                                       Prestamo.Id_socio+ "','" +
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









        //--------------Metodo para cargar los libros en el combobox----------------
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
                Comando.CommandTimeout = 60;
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

            // Obtenemos la id del libro usando el nombre a su nombre
            string query1 = "SELECT id_libro FROM libros WHERE titulo = '" + NombreLibro + "'";
            MySqlCommand cm1 = new MySqlCommand(query1, conn);

            var idLibro = cm1.ExecuteScalar();// ExecuteScalar lo usamos para guardar solo 1 valor

            // Consultamos  y filtramos las copias disponibles
            string query2 = "SELECT id_copialibros FROM copia_libros WHERE id_libro = '" + idLibro + "' AND id_copialibros NOT IN (SELECT id_copialibros FROM prestamos)";
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
            // Proporcionamos un mensaje de error específico
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








    // metodo para cargar los ejemplares en el combobox
    public DataTable CargaComboLibrosEjemplares(string libro)
        {
            MySqlDataReader Resultado;
            var Tabla = new DataTable();
            var SqlCon = new MySqlConnection();
            try
            {
                SqlCon = M_Conexion.getInstancia().CrearConexion();
                string sql_tarea = "SELECT id_copialibros,id_libro FROM copia_libros WHERE id_libro =" + libro + " AND id_copialibros NOT IN (SELECT id_copialibros FROM prestamos WHERE fecha_real_devolucion IS NULL AND id_libro=" + libro + ") ORDER BY id_copialibros;";

                var Comando = new MySqlCommand(sql_tarea, SqlCon);
                Comando.CommandTimeout = 60;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
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




        public static List<M_Bibliotecarios> ObtenerBibliotecarios()
        {
            List<M_Bibliotecarios> listaLibros = new List<M_Bibliotecarios>();

            MySqlConnection conn = M_Conexion.getInstancia().CrearConexion();

            string query = "SELECT apellido FROM bibliotecarios";

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(query, conn);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    M_Bibliotecarios Bibliotecarios = new M_Bibliotecarios(reader["apellido"].ToString());
                    listaLibros.Add(Bibliotecarios);
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

            return listaLibros;
        }



        public static void CargarBibliotecarios(ComboBox comboBoxLibro)
        {
            List<M_Bibliotecarios> listaBibliotecarios = ObtenerBibliotecarios();

            foreach (M_Bibliotecarios Bibliotecario in listaBibliotecarios)
            {
                comboBoxLibro.Items.Add(Bibliotecario.Apellido);
            }
        }

    }
}


