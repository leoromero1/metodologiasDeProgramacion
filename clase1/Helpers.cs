
using clase1.models;
using clase1.interfaces;

namespace clase1;

public class Helpers
{
    public static void Llenar(Coleccionable c)
    {
        Random random = new Random();
        for (int i = 0; i < 20; i++)
        {
            c.Agregar(new Numero(random.Next(1, 50)));
        }
    }

    public static void Informar(Coleccionable c)
    {
        Console.Write("Cuantos: ");
        Console.WriteLine(c.Cuantos());
        Console.Write("Minimo: ");
        Console.WriteLine(c.Minimo());
        Console.Write("Maximo: ");
        Console.WriteLine(c.Maximo());
        Console.WriteLine("Ingrese un legajo a buscar: ");

        int legajo = int.Parse(Console.ReadLine());
        Comparable alumno = new Alumno("Leo", 0, legajo, 0);

        if (c.Contiene(alumno))
        {
            Console.WriteLine($"El alumno con legajo {legajo} está en la colección.");
        }
        else
        {
            Console.WriteLine($"El alumno con legajo {legajo} NO está en la colección.");
        }

        Console.WriteLine("----------------------------------------");
    }

    public static void LlenarAlumnos(Coleccionable c)
    {
        Random random = new Random();
        for (int i = 0; i < 20; i++)
        {
            string nombre = "Alumno" + i;
            int dni = random.Next(38611820, 38611850);
            int legajo = random.Next(0, 25);
            float promedio = (float)(random.NextDouble() * 10);
            Comparable alumno = new Alumno(nombre, dni, legajo, promedio);

            c.Agregar(alumno);
        }
    }
}
