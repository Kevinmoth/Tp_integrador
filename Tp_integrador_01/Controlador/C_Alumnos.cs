using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp_integrador_01.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tp_integrador_01.Controlador
{
    public class C_Alumnos
    {
        M_Alumnos modeloAlumnos = new M_Alumnos();


        public void insertarAlumnos(string apellido, string nombre, string dni, string telefono, string direccion, string email, int localidad)
        {
            M_Alumnos alumno = new M_Alumnos(apellido, nombre, dni, telefono, direccion, email, localidad);

            almacenarBD.AlmacenarAlumno(alumno);
            //modeloAlumnos.insertarAlumnosBD(apellido, nombre, dni, telefono, direccion, email, localidad);
        }

    }
}
