using clase5.interfaces;
using clase5.models;

namespace clase5.factoryMethod;

public class FabricaDeAlumnos : FabricaDeComparables
{
    public override Comparable CrearAleatorio()
    {
        Random random = new Random();
        GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio();
        string nombre = generador.StringAleatorio(5);
        int dni = random.Next(18, 30);
        int legajo = random.Next(0, 25);
        float promedio = (float)(random.NextDouble() * 10);
        int calificacion = random.Next(1, 11);
        return new Alumno(nombre, dni, legajo, promedio, calificacion);
    }
    public override Comparable CrearPorTeclado()
    {
        string nombre = LectorDeDatos.TextoPorteclado();
        int dni = LectorDeDatos.NumeroPorteclado();
        int legajo = LectorDeDatos.NumeroPorteclado();
        float promedio = (float)LectorDeDatos.NumeroPorteclado();
        int calificacion = LectorDeDatos.NumeroPorteclado();
        return new Alumno(nombre, dni, legajo, promedio, calificacion);
    }
}
