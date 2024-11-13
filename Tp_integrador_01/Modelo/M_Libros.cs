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

        private String titulo;


        public M_Libros(string v)
        {
            this.titulo = v;
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

    }
}