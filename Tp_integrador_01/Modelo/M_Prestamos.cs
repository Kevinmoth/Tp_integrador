using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_integrador_01.Modelo
{

    public class M_Prestamo
    {
        private string libro;
        private string alumno;
        private string bibliotecario;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;
        private string estado;
        private string copiaLibro;

        //public M_Prestamo(string apellido)
        
            public M_Prestamo(string libro, string alumno, string bibliotecario, DateTime fechaPrestamo, DateTime fechaDevolucion, string estado, string CopiaLibro)
        {
            this.libro = libro;
            this.alumno = alumno;
            this.bibliotecario = bibliotecario;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaDevolucion = fechaDevolucion;
            this.estado = estado;
            this.copiaLibro = CopiaLibro;
        }

        // Propiedadess
        public string Libro { get { return libro; } set { libro = value; } }
        public string Alumno { get { return alumno; } set { alumno = value; } }
        public string Bibliotecario { get { return bibliotecario; } set { bibliotecario = value; } }
        public DateTime FechaPrestamo { get { return fechaPrestamo; } set { fechaPrestamo = value; } }
        public DateTime FechaDevolucion { get { return fechaDevolucion; } set { fechaDevolucion = value; } }
        public string Estado { get { return estado; } set { estado = value; } }

        public string CopiaLibro { get { return copiaLibro; } set { copiaLibro = value; } }
    }

}




