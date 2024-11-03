using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_integrador_01.Controlador;


namespace Tp_integrador_01
{
    public partial class BiblioMax : Form
    {
        C_Alumnos controladorAlumnos;
        public BiblioMax()
        {
            
            /*Para trabajar con el controlador, necesitamos instanciar
            AsyncCallback su clase, lo hacermos primero declarando un;
            objeto de tipo c_alumnos y luego instanciando: */

            InitializeComponent();
            C_Alumnos controladorAlumnos = new C_Alumnos();
        }


        /* Creamos un metodo que recolecte los datos del formulario
        Y los envie a una funcion del controlador:*/

        public void GuardarAlumnos()
        {
            string apellido = apellido_txt.Text;
            string nombre = apellido_txt.Text;
            string dni = apellido_txt.Text;
            string telefono = apellido_txt.Text;
            string direccion = apellido_txt.Text;
            string email = mail_txt.Text;
            int localidad = localidad_txt.SelectedIndex;

            controladorAlumnos.insertarAlumnos( apellido, nombre, dni, telefono, direccion, email, localidad);
        }



        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Alumnos_Click(object sender, EventArgs e)
        {

        }

        private void registrar_boton_Click(object sender, EventArgs e)
        {
            GuardarAlumnos();
        }
    }
}
