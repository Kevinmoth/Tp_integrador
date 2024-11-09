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

        //Atrubutos del alumno:
        private string apellido;
        private string nombre;
        private string dni;
        private string telefono;
        private string direccion;
        private string email;
        private int localidad;
        // constructor de alumnos
        public M_Alumnos(string apellido, string nombre,
            string dni, string telefono, string direccion, 
            string email, int localidad)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.localidad = localidad;
        }


        /*Getters y setters - En C#, en vez de crear un getter y un setter para cada atributo
        podemos crear estos metodos que sirven para ambas cosas:

            public string Matricula{

                 get { return matricula; }   // Getter: devuelve el valor de "matricula"
                 set { matricula = value; }  // Setter: asigna un valor a "matricula"
            }
        
        en c# a este metodo se le llama "propiedad" de la clase, y no getter o setter
        asi podemos acceder a los atributos:

        alumno.Nombre = "Carlos"; // Usa el setter internamente
        Console.WriteLine(alumno.Nombre); // Usa el getter internamente */

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }








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
