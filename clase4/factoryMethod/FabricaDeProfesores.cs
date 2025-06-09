using clase4.interfaces;
using clase4.models;

namespace clase4.factoryMethod;
public class FabricaDeProfesores : FabricaDeComparables
{
    public override Comparable CrearAleatorio()
    {
        Random random = new Random();
        GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio();
        string nombre = generador.StringAleatorio(5);
        int dni = random.Next(18, 30);
        int antiguedad = random.Next(0, 25);
        return new Profesor(nombre, dni, antiguedad);
    }

    public override Comparable CrearPorTeclado()
    {
        string nombre = LectorDeDatos.TextoPorteclado();
        int dni = LectorDeDatos.NumeroPorteclado();
        int antiguedad = LectorDeDatos.NumeroPorteclado();
        return new Profesor(nombre, dni, antiguedad);
    }
}
