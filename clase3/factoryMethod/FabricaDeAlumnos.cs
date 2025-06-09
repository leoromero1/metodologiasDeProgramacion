using clase3.interfaces;
using clase3.models;

namespace clase3.factoryMethod;

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
        return new Alumno(nombre, dni, legajo, promedio);
    }
    public override Comparable CrearPorTeclado()
    {
        string nombre = LectorDeDatos.TextoPorteclado();
        int dni = LectorDeDatos.NumeroPorteclado();
        int legajo = LectorDeDatos.NumeroPorteclado();
        float promedio = (float)LectorDeDatos.NumeroPorteclado();
        return new Alumno(nombre, dni, legajo, promedio);
    }
}
