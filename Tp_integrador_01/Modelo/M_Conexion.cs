using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tp_integrador_01.Modelo
{


    internal class M_Conexion
    {
        //Atributos de la clase M_Conexion
        private string base_datos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static M_Conexion conn = null;


        //constructores
        private M_Conexion()
        {
            this.base_datos = "biblioteca_parcial";
            this.puerto = "3306";
            this.servidor = "127.0.0.1";
            this.clave = "seadesert1550";
            this.usuario = "root";
        }

        public MySqlConnection CrearConexion()
        {
            try
            {
                var cadena = new MySqlConnection();
                cadena.ConnectionString = "datasource=" + this.servidor +
                          ";user=" + this.usuario +
                          ";password=" + this.clave +
                          ";database=" + this.base_datos +
                          ";SslMode=Required";
                return cadena;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la conexión: " + ex.Message);
                throw;  // Rethrow the exception to handle it in a higher level
            }
        }



        public static M_Conexion getInstancia()
        {
            if (conn == null)
            {
                conn = new M_Conexion();
            }
            return conn;
        }


    }
}


