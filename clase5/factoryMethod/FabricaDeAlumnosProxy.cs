using clase5.interfaces;
using clase5.models;
using clase5.proxy;

namespace clase5.factoryMethod;

public class FabricaDeAlumnosProxy : FabricaDeComparables
{
    public override Comparable CrearAleatorio()
    {
        Random random = new Random();
        GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio();
        string nombre = generador.StringAleatorio(6);

        return new AlumnoProxy(nombre);
    }
    public override Comparable CrearPorTeclado()
    {
        string nombre = LectorDeDatos.TextoPorteclado();
        return new AlumnoProxy(nombre);
    }
}