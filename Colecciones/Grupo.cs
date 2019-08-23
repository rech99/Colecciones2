using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Grupo
    {
        public string Materia { get; set; }
        public string Codigo { get; set; }
    public List<Alumnos> Alumnos { get; set; }

        public Grupo(string materia, string codigo)
        {
            Materia = materia;
            Codigo = codigo;
            Alumnos = new List<Alumnos>();

            Alumnos alumno1;
            alumno1 = new Alumnos("Jose", "1234");
            alumno1.Nombre = "Jose";

        }
}
}
