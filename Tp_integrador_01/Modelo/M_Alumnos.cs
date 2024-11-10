using MySql.Data.MySqlClient;
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

    /*Esta clase se encarga de definir los datos básicos de un alumno y
    proporciona una forma de acceder a ellos y modificarlos cuando se necesite.*/

    public class M_Alumnos
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
        podemos crear estos metodos llamados "propiedades" que sirven para ambas cosas:

            public string Matricula{

                 get { return matricula; }   // Getter: devuelve el valor de "matricula"
                 set { matricula = value; }  // Setter: asigna un valor a "matricula"
            }
        
        En c# a este tipo de metodo se le llama "propiedad" y es asi como podemos acceder a el:

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



    }
}
