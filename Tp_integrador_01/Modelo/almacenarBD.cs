using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_integrador_01.Modelo
{
    internal class almacenarBD
    {

        public static void AlmacenarAlumno(M_Alumnos alumno)
        {
            string apellido = alumno.Apellido;
            string nombre = alumno.Nombre;
            string dni = alumno.Dni;
            string telefono = alumno.Telefono;
            string direccion = alumno.Direccion;
            string email = alumno.Email;
            string localidad = alumno.Localidad;

            M_Conexion conexion = M_Conexion.getInstancia();
            MySqlConnection conn = conexion.CrearConexion();

            // Abrimos la conexión 
            conn.Open();

            // Creamos el comando SQL para insertar datos
            string query = "INSERT INTO socios (apellido, nombre, dni, telefono, direccion, email, id_localidad) " +
                "VALUES ('" + alumno.Apellido + "', '" + alumno.Nombre + "', '" + alumno.Dni + "', '" +
                alumno.Telefono + "', '" + alumno.Direccion + "', '" + alumno.Email + "', " +
                "(SELECT id_localidad FROM localidad WHERE nombre_localidad = '" + alumno.Localidad + "'))";

            MySqlCommand comando = new MySqlCommand(query, conn);

            // Ejecutamos el comando (solo una vez)
            comando.ExecuteNonQuery();

            // Cerramos la conexión
            conn.Close();
        }

       /* public static void almacenarBibliotecario(M_Bibliotecarios bibliotecario) { }
        public static void almacenarLibro(M_Libros Libro) { }
        public static void almacenarPrestamo(M_Prestamos prestamo) { }*/

    }
}

