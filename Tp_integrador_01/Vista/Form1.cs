using PJ_conexionIntegrador.Controlador;
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
using Tp_integrador_01.Modelo;


namespace Tp_integrador_01
{
    public partial class BiblioMax : Form
    {
        private C_Alumnos controladorAlumnos;
        private C_Libro controladorLibros;
        public BiblioMax()
        {

            /*Para trabajar con el controlador, necesitamos instanciar
            su clase, lo hacermos primero declarando un
            objeto de tipo c_alumnos y luego instanciando: */
            
        InitializeComponent();
            controladorAlumnos = new C_Alumnos();
            controladorLibros = new C_Libro();
            CargarDatosEnTabla();
        }

        private void CargarDatosEnTabla()
        {
            List<M_Alumnos> listaAlumnos = controladorAlumnos.ObtenerAlumnos();

            // Vincular la lista al DataGridView
            dataGridAlumno.DataSource = listaAlumnos;
        }

        /* Creamos un metodo que recolecte los datos del formulario
        Y los envie a una funcion del controlador:*/

        public void GuardarAlumnos()
        {
            string apellido = apellido_txt.Text;
            string nombre = nombre_txt.Text;
            string dni = dni_txt.Text;
            string telefono = telefono_txt.Text;
            string direccion = direccion_txt.Text;
            string email = mail_txt.Text;
            string localidad = (string)localidad_txt.SelectedItem;

            controladorAlumnos.insertarAlumnos(apellido, nombre, dni, telefono, direccion, email, localidad);
        }



       
        
        public void cargarComboBox()
        {

            // Llamamos al controlador para obtener los datos del libro
            string nombre_libro = (string)comboBoxLibro.SelectedItem;
            DataTable copias = C_Prestamos.datosComboBoxLibro(nombre_libro);

            // Asignamos los datos al ComboBox
            comboBoxEjemplar.DataSource = copias;
            comboBoxEjemplar.DisplayMember = "id_copialibros"; // Mostrar el id
            comboBoxEjemplar.ValueMember = "id_copialibros";   // Valor que se almacenará
        }





        private void MostrarPrestamos()
        {
            // Llamar a la función ListadoPrestamos para obtener los datos
            DataTable dt = C_Prestamos.ListadoPrestamos();

            // Asignar el DataTable al DataGridView
            TablaPrestamos.DataSource = dt;
        }



        //Codigo para rellenar el comboBox
        public void comboBoxAlumnos()
        {
            controladorAlumnos.CargarNombresComboBox(comboBoxAlumno);
        }
        public void comboBoxLibros()
        {
            controladorLibros.CargarLibros(comboBoxLibro);
        }
        public void comboBoxBibliotecario()
        {
            C_Prestamos.CargarBibliotecarios(comboBoxBibliotecarios);
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
            CargarDatosEnTabla();
        }


        private void libro_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void mail_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void localidad_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BiblioMax_Load(object sender, EventArgs e)
        {
            localidad_txt.SelectedIndex = 0;
            comboBoxAlumnos();
            comboBoxLibros();
            comboBoxBibliotecario();
            MostrarPrestamos();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            GuardarAlumnos();
            CargarDatosEnTabla();
        }

        private void apellido_txt_Click(object sender, EventArgs e)
        {

        }

        private void direccion_txt_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboBox();
        }

        private void comboBoxLibro_TextChanged(object sender, EventArgs e)
        {




        }
    }
}
