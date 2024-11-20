using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_integrador_01.Modelo
{

    public class M_Prestamo
    {
        int id_prestamo;
        int id_socio;
        int id_libro;
        int id_copialibros;
        int id_bibliotecario;
        private DateTime fecha_prestamo;
        DateTime fecha_real_devolucion;
        DateTime fecha_devolucion;



        //cosntructor sin parametros:

        public  M_Prestamo()
        {

        }

        //constructor con parametros:

        public M_Prestamo(int id_prestamo, int id_socio, int id_libro, int id_copialibros, int id_bibliotecario, DateTime fecha_prestamo, DateTime fecha_real_devolucion, DateTime fecha_devolucion)
        {
            this.id_prestamo = id_prestamo;
            this.id_socio = id_socio;
            this.id_libro = id_libro;
            this.id_copialibros = id_copialibros;
            this.id_bibliotecario = id_bibliotecario;
            this.fecha_prestamo = fecha_prestamo;
            this.fecha_real_devolucion = fecha_real_devolucion;
            this.fecha_devolucion = fecha_devolucion;
        }

        // Propiedades


        public int Id_prestamo{get { return id_prestamo; } set { id_prestamo = value; }}
        public int Id_socio { get { return id_socio; } set { id_socio = value; }}
        public int Id_libro {get { return id_libro; } set { id_libro = value; }}
        public int Id_copialibros { get { return id_copialibros; } set { id_copialibros = value; }}
        public int Id_bibliotecario { get { return id_bibliotecario; } set { id_bibliotecario = value; }}
        public DateTime Fecha_prestamo { get { return fecha_prestamo; } set { fecha_prestamo = value; }}
        public DateTime Fecha_real_devolucion { get { return fecha_real_devolucion; } set { fecha_real_devolucion = value; }}
        public DateTime Fecha_devolucion { get { return fecha_devolucion; } set { fecha_devolucion = value; }}


    }









}




