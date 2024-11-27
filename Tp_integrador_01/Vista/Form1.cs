using PJ_conexionIntegrador.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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

            InitializeComponent();
            controladorAlumnos = new C_Alumnos();
            controladorLibros = new C_Libro();
            CargarDatosEnTabla();
        }




        //                                   CARGA DE DATOS EN TABLA




        //----------------------------- Metodo para cargar la tabla de Alumnos ---------------------------
        private void CargarDatosEnTabla()
        {
            List<M_Alumnos> listaAlumnos = controladorAlumnos.ObtenerAlumnos();

            // Vincular la lista al DataGridView
            dataGridAlumno.DataSource = listaAlumnos;
        }


        //--------------------------- Metodo para Mostrar Prestamos en el DataGridView ---------------------------
        private void MostrarPrestamos()
        {
            // Llamar a la función ListadoPrestamos para obtener los datos
            DataTable dt = C_Prestamos.ListadoPrestamos();

            // Asignar el DataTable al DataGridView
            TablaPrestamos.DataSource = dt;
        }


        //------------------metodo para cargar la tabla de suspensiones---------------------
        public void MostrarSuspensiones()
        {

            DataTable dt = C_Prestamos.ListadoSuspensiones();
            TablaSuspensiones.DataSource = dt;

        }



        //                             - OBTENCION DE DATOS DE FORMULARIO -



        /* Creamos un metodo GuardarAlumnos() que recolecte los datos del formulario
        Y los envie como parametro a la funcion insertarAlumnos() del controlador. */

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

        //-----------metodo para capturar datos del prestamo y enviarlos al controlador---------------------
        public void GuardarPrestamo()
        {
            string alumno = (string)comboBoxAlumno.SelectedItem;
            String libro = (string)comboBoxLibro.SelectedItem;
            String bibliotecario = (string)comboBoxBibliotecarios.SelectedItem;
            int id_copialibro = Convert.ToInt32(comboBoxEjemplar.SelectedValue);


            C_Prestamos.generarPrestamo(alumno, libro, bibliotecario, id_copialibro);
        }


        //------------------Metodo que retorena el dni del alumno seleccionado en el dataGrid---------------------------
        public int obtenerDniSeleccionado()
        {
            DataGridViewRow filaSeleccionada = dataGridAlumno.CurrentRow;
            int dniSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["dni"].Value);
            return dniSeleccionado;
        }


        //------------------metodo para capturar datos de la devolucion y enviarlos al controlador---------------------
        public void agregarDevolucion()
        {

            // Capturamos la id del prestamo seleccionado en la tabla
            int id_prestamo = Convert.ToInt32(TablaPrestamos.CurrentRow.Cells["id_prestamo"].Value);
            //obtiene la fechad e devolucion del prestamo seleccionado en la tabla
            DateTime fecha_devolucion = DateTime.Parse(TablaPrestamos.CurrentRow.Cells["fecha_devolucion"].Value.ToString());
            //obtiene la fecha actual como datetime
            DateTime fecha_devolucion_real = DateTime.Now;


            C_Prestamos.agregarDevolucion(fecha_devolucion, fecha_devolucion_real, id_prestamo);

        }

        //------------------metodo para capturar el id de una suspencion 
        public void obtenerDatosSuspension()
        {
            int id_prestamo = Convert.ToInt32(TablaSuspensiones.CurrentRow.Cells["id_suspencion"].Value);
            C_Prestamos.quitarSuspension(id_prestamo);

        }




        //                                    - CARGAR LOS COMBOBOX -




        //--------------------------- Metodo para cargar el comboBox de Libros ---------------------------
        public void cargarComboBox()
        {

            // Llamamos al controlador para obtener los datos del libro
            string nombre_libro = (string)comboBoxLibro.SelectedItem;
            DataTable copias = C_Prestamos.datosComboBoxLibro(nombre_libro);

            // Asignamos los datos al ComboBox
            comboBoxEjemplar.DataSource = copias;
            comboBoxEjemplar.DisplayMember = "id_copialibros";
            comboBoxEjemplar.ValueMember = "id_copialibros";   
        }


        //.-------------------------- Metodo para cargar el comboBox de Alumnos ---------------------------
        public void comboBoxAlumnos()
        {
            controladorAlumnos.CargarNombresComboBox(comboBoxAlumno);
        }



        //---------------------------- Metodo para cargar el comboBox de Libros ---------------------------
        public void comboBoxLibros()
        {
            controladorLibros.CargarLibros(comboBoxLibro);
        }


        //---------------------------- Metodo para cargar el comboBox de Bibliotecarios ---------------------
        public void comboBoxBibliotecario()
        {
            C_Prestamos.CargarBibliotecarios(comboBoxBibliotecarios);
        }

        

        

        
        //                                    - BOTONES -


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
            MostrarSuspensiones();


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

        private void Eliminar_Alumno_Click(object sender, EventArgs e)
        {

            int dni = obtenerDniSeleccionado();
            C_Alumnos.EliminarAlumno(dni);
            CargarDatosEnTabla();

        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            GuardarPrestamo();
            MostrarPrestamos();

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

            // funcion para agregar una devolucion
            agregarDevolucion();
            MostrarPrestamos();
            MostrarSuspensiones();

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            //llamamos a la funcion apra eliminar una suspencion
            obtenerDatosSuspension();
            MostrarSuspensiones();



        }

        private void apellido_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)  
            {
                e.Handled = true;
            }
        }

        private void nombre_txt_Click(object sender, EventArgs e)
        {

        }

        private void nombre_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void dni_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void telefono_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
