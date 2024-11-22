using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_integrador_01.Modelo
{
    internal class M_Libros
    {
        private int id_libro;
        private String titulo;

        //constructores
        public M_Libros(string titulo)
        {
            this.titulo = titulo;
        }

        //constructor con parámetros 
        public M_Libros( int id_libro, string titulo) {
            this.id_libro = id_libro;
            this.titulo = titulo;
        }




        //getters y setters
        public int Id_libro

        {
            get { return id_libro; }
            set { id_libro = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

    }
}