using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Hijo1 : Padre
    {
        public string Hobby { get; set; }
        public string Deporte { get; set; }

        // Método específico de Hijo1
        public void MostrarInfoHijo1()
        {
            Console.WriteLine($"Hobby: {Hobby}, Deporte: {Deporte}");
        }

    }
}