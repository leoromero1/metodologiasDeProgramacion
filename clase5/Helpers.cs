
using clase5.models;
using clase5.interfaces;
using clase5.factoryMethod;

namespace clase5;

public class Helpers
{
    public static void Llenar(Coleccionable c, int opcion)
    {
        Random random = new Random();
        for (int i = 0; i < 20; i++)
        {
            Comparable comparable = FabricaDeComparables.CrearAleatorio(opcion);
            c.Agregar(comparable);
        }
    }

    public static void Informar(Coleccionable c, int opcion)
    {
        Console.Write("Cuantos: ");
        Console.WriteLine(c.Cuantos());
        Console.Write("Minimo: ");
        Console.WriteLine(c.Minimo());
        Console.Write("Maximo: ");
        Console.WriteLine(c.Maximo());
        Comparable comparable = FabricaDeComparables.CrearAleatorio(opcion);
        if (c.Contiene(comparable))
        {
            Console.WriteLine($"El elemento {comparable} está en la colección.");
        }
        else
        {
            Console.WriteLine($"El elemento {comparable} no está en la colección.");
        }
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
            int calificacion = random.Next(1, 11);
            Comparable alumno = new Alumno(nombre, dni, legajo, promedio, calificacion);

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

     public static void CambiarEstrategiaProfesores(Iterable i, EstrategiaProfesor estrategia)
    {
        Iterador iterador = i.CrearIterador();
        iterador.Primero();
        while (!iterador.Fin())
        {
            Comparable com = iterador.Actual();
            if (com is Profesor profesor)
            {
                profesor.SetEstrategia(estrategia);
            }
            iterador.Siguiente();
        }
    }

    // Practica 3 - ejercicio 13:
    public static void DictadoDeClases(Profesor profesor)
    {
        for (int i = 0; i < 5; i++)
        {
            profesor.HablarALaClase();
            profesor.EscribirEnElPizarron();
        }
    }
}
