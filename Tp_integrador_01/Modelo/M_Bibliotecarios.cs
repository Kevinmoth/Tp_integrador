using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_integrador_01.Modelo
{
    public class M_Bibliotecarios
    {
        /*private string idBibliotecario;
        private string nombre;*/
        private string apellido;
        /*private string direccion;
        private string email;
        private decimal salario;
        private int antiguedad;*/

        // Constructor de la clase
        public M_Bibliotecarios(string apellido){
        //public M_Bibliotecarios(string idBibliotecario, string nombre, string apellido, string direccion, string email, decimal salario, int antiguedad)
   
            /*this.idBibliotecario = idBibliotecario;
            this.nombre = nombre;*/
            this.apellido = apellido;
            /*this.direccion = direccion;
            this.email = email;
            this.salario = salario;
            this.antiguedad = antiguedad;*/
        }

        // Propiedades
        /*public string IdBibliotecario { get { return idBibliotecario; } set { idBibliotecario = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }*/
        public string Apellido { get { return apellido; } set { apellido = value; } }
        /*public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Email { get { return email; } set { email = value; } }
        public decimal Salario { get { return salario; } set { salario = value; } }
        public int Antiguedad { get { return antiguedad; } set { antiguedad = value; } }*/
    }


}
