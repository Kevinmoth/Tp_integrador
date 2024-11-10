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
            int localidad = alumno.Localidad;

            M_Conexion conexion = M_Conexion.getInstancia();
            MySqlConnection conn = conexion.CrearConexion();

            
                // Abrirmos la conexion 
            conn.Open();

                // Creamos el comando SQL para insertar datos
            string query = "INSERT INTO alumnos (apellido, nombre, dni, telefono, direccion, email, localidad) " +
            "VALUES ('" + alumno.Apellido + "', '" + alumno.Nombre + "', '" + alumno.Dni + "', '" +
            alumno.Telefono + "', '" + alumno.Direccion + "', '" + alumno.Email + "', " + alumno.Localidad + ")";

            MySqlCommand comando = new MySqlCommand(query, conn);
            comando.ExecuteNonQuery();


                // Ejecutamos el comando
            int result = comando.ExecuteNonQuery();
                // Cerramos la conexión
            conn.Close();
            }

        }
    }

