using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Hijo2 : Padre
    {
        public float Calificacion { get; set; }
        public string Asignatura { get; set; }

        // Método específico de Hijo2
        public void MostrarInfoHijo2()
        {
            Console.WriteLine($"Calificación: {Calificacion}, Asignatura: {Asignatura}");
        }
    }

}