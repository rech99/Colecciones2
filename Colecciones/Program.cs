using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> grupos = new List<Grupo>();


            Grupo matematicas =
                new Grupo("Matematicas", "MAT546");
            Grupo historia =
                new Grupo("Matematicas", "HST667");

            grupos.Add(matematicas);
            grupos.Add(historia);

            Alumnos juan = new Alumnos("Juan", "162345");
            Alumnos maria = new Alumnos("Maria", "123582");
            Alumnos pedro = new Alumnos("Pedro", "74185");
            Alumnos pablo = new Alumnos("Pablo", "158678");
            Alumnos ana = new Alumnos("Ana", "192903");

            historia.Alumnos.Add(juan);
            historia.Alumnos.Add(ana);
            historia.Alumnos.Add(pedro);

            matematicas.Alumnos.Add(juan);
            matematicas.Alumnos.Add(maria);
            matematicas.Alumnos.Add(pedro);
            matematicas.Alumnos.Add(ana);
            matematicas.Alumnos.Add(pablo);

            foreach(Grupo grupo in grupos)
            {
                Console.WriteLine("Grupo: " +
                    grupo.Codigo);
                Console.WriteLine("Materia: " +
                    grupo.Materia);

                Console.WriteLine("Lista de Alumnos: ");
                foreach (Alumnos alumnos in grupo.Alumnos)
                {
                    Console.WriteLine("*" +
                        alumnos.Nombre);
                }

            }



            Console.Read();
        }
    }
}
