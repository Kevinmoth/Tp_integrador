using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp_integrador_01.Modelo;

namespace Tp_integrador_01.Controlador
{
    internal class C_Alumnos
    {
        M_Alumnos modeloAlumnos = new M_Alumnos();


        public void insertarAlumnos(string apellido, string nombre, string dni, string telefono, string direccion)
        {
            modeloAlumnos.insertarAlumnosBD( apellido, nombre, dni, telefono, direccion);
        }
    }
}
