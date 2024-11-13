using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_integrador_01.Modelo;

namespace Tp_integrador_01.Controlador
{
    internal class C_Libro
    {

        public static List<M_Libros> ObtenerLibros()
        {
            List<M_Libros> listaLibros = new List<M_Libros>();

            MySqlConnection conn = M_Conexion.getInstancia().CrearConexion();

            string query = "SELECT titulo FROM libros";

            try
            {
                conn.Open();
                MySqlCommand comando = new MySqlCommand(query, conn);
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    M_Libros libros = new M_Libros(reader["titulo"].ToString());
                    listaLibros.Add(libros);
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                // Maneja excepciones para evitar cierres pro errores de conexion
                Console.WriteLine("Error al obtener los datos: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return listaLibros;
        }



        public void CargarLibros(ComboBox comboBoxLibro)
        {
            List<M_Libros> listaLibros = ObtenerLibros();

            foreach (M_Libros libros in listaLibros)
            {
                comboBoxLibro.Items.Add(libros.Titulo);
            }
        }


    }
}
