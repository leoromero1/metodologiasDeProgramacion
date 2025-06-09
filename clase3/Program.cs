using clase3;
using clase3.factoryMethod;
using clase3.models;
class Program
{
    static void Main(string[] args)
    {
        /*
        // Practica 3 - ejercicio 6:
        Pila pila = new Pila();
        Console.WriteLine("Pila: ");
        Helpers.Llenar(pila, 2);
        Helpers.Informar(pila, 2);
        */
        /*
        // Practica 3 - ejercicio 9:
        //opcion 1: Pila de numeros
        //opcion 2: Pila de alumnos
        //opcion 3: Pila de profesores
        Console.WriteLine("Pila de numeros");
        int opcion = 1;
        Pila pila = new Pila();
        Helpers.Llenar(pila, opcion);
        Helpers.Informar(pila, opcion);
        Console.WriteLine("");
        Console.WriteLine("Pila de alumnos");
        int opcion2 = 2;
        Pila pila2 = new Pila();
        Helpers.Llenar(pila2, opcion2);
        Helpers.Informar(pila2, opcion2);
        Console.WriteLine("");
        Console.WriteLine("Pila de profesores");
        int opcion3 = 3;
        Pila pila3 = new Pila();
        Helpers.Llenar(pila3, opcion3);
        Helpers.Informar(pila3, opcion3);
        */
        // Practica 3 - ejercicio 14:

        Profesor profesor = (Profesor)FabricaDeComparables.CrearAleatorio(3);
        for (int i = 0; i < 20; i++)
        {
            Alumno alumno = (Alumno)FabricaDeComparables.CrearAleatorio(2);
            profesor.AgregarObservador(alumno);
        }
        Console.WriteLine(profesor);
        Helpers.DictadoDeClases(profesor);
    }
}