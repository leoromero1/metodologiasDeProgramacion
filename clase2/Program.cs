using clase2;
using clase2.models;
using clase2.strategy;

class Program
{
    static void Main(string[] args)
    {
        // Practica 2 - Ejercicio 7
        /*
        Pila pila = new Pila();
        Cola cola = new Cola();
        Conjunto conjunto = new Conjunto();
        Helpers.LlenarAlumnos(pila);
        Helpers.LlenarAlumnos(cola);
        Helpers.LlenarAlumnos(conjunto);
        Console.WriteLine("Pila:");
        Helpers.ImprimirElementos(pila);
        Console.WriteLine("Cola:");
        Helpers.ImprimirElementos(cola);
        Console.WriteLine("Conjunto:");
        Helpers.ImprimirElementos(conjunto);
        */

        // Practica 2 - Ejercicio 9
        Pila pila = new Pila();
        Helpers.LlenarAlumnos(pila);
        Console.WriteLine("Estrategia por Nombre");
        Helpers.CambiarEstrategia(pila, new EstrategiaPorNombre());
        Helpers.Informar(pila);
        Console.WriteLine("Estrategia por Legajo");
        Helpers.CambiarEstrategia(pila, new EstrategiaPorLegajo());
        Helpers.Informar(pila);
        Console.WriteLine("Estrategia por Promedio");
        Helpers.CambiarEstrategia(pila, new EstrategiaPorPromedio());
        Helpers.Informar(pila);
        Console.WriteLine("Estrategia por DNI");
        Helpers.CambiarEstrategia(pila, new EstrategiaPorDni());
        Helpers.Informar(pila);
    }
}