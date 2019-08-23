using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Alumnos
    {
    public string Nombre { get; set;}
    public string Matricula { get; set;}

        public Alumnos(string nombre, string matricula)
        {
            Nombre = nombre;
            Matricula = matricula;
        }
}
}
