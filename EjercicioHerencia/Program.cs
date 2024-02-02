using EjercicioHerencia;

internal class Program
{
    class Programa    {
        static void Main()
        {
          
            Hijo1 hijo1 = new Hijo1
            {
                Nombre = "Juan",
                Edad = 25,
                Genero = "Masculino",
                Direccion = "Calle Principal, Tegucigalpa",
                Hobby = "Pintar",
                Deporte = "Fútbol"
            };

         
            Hijo2 hijo2 = new Hijo2
            {
                Nombre = "María",
                Edad = 20,
                Genero = "Femenino",
                Direccion = "Calle vieja, Tela",
                Calificacion = 9.5f,
                Asignatura = "Matemáticas"
            };

          
            Console.WriteLine("Información del Hijo1:");
            Console.WriteLine($"Nombre: {hijo1.Nombre}, Edad: {hijo1.Edad}, Género: {hijo1.Genero}, Dirección: {hijo1.Direccion}");
            hijo1.MostrarInfoHijo1();

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Console.WriteLine("\nInformación del Hijo2:");
            Console.WriteLine($"Nombre: {hijo2.Nombre}, Edad: {hijo2.Edad}, Género: {hijo2.Genero}, Dirección: {hijo2.Direccion},");
            hijo2.MostrarInfoHijo2();
        }
    }
}