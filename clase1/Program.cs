using clase1;
using clase1.models;

class Program
{
    static void Main(string[] args)
    {
        //ejercicio 7
        /*
        Pila pila = new Pila();
        Cola cola = new Cola();
        Helpers.Llenar(pila);
        Helpers.Llenar(cola);
        Helpers.Informar(pila);
        Helpers.Informar(cola);
        */
        //ejercicio 9
        /*
        Pila pila = new Pila();
        Cola cola = new Cola();
        ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
        Helpers.Llenar(pila);
        Helpers.Llenar(cola);
        Helpers.Informar(pila);
        Helpers.Informar(cola);
        Console.WriteLine("Mutiple");
        Helpers.Informar(multiple);
        */
        //ejercicio 14
        Pila pila = new Pila();
        Cola cola = new Cola();
        ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
        Helpers.LlenarAlumnos(pila);
        Helpers.LlenarAlumnos(cola);
        Helpers.Informar(multiple);
    }
}