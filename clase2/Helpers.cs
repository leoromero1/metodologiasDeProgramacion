
using clase2.models;
using clase2.interfaces;

namespace clase2;

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

    public static void ImprimirElementos(Iterable i)
    {
        Iterador iterador = i.CrearIterador();
        iterador.Primero();
        while (!iterador.Fin())
        {
            Comparable com = iterador.Actual();
            Console.WriteLine(com);
            iterador.Siguiente();
        }
    }

    public static void CambiarEstrategia(Iterable i, EstrategiaDeComparacion estrategia)
    {

        Iterador iterador = i.CrearIterador();
        iterador.Primero();
        while (!iterador.Fin())
        {
            Comparable com = iterador.Actual();
            if (com is Alumno alumno)
            {
                alumno.SetEstrategia(estrategia);
            }
            iterador.Siguiente();
        }
    }
}
