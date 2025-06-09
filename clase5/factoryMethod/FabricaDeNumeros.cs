using clase5.interfaces;
using clase5.models;

namespace clase5.factoryMethod;

public class FabricaDeNumeros : FabricaDeComparables
{
    public override Comparable CrearAleatorio()
    {
        Random random = new Random();
        GeneradorDeDatosAleatorio generador = new GeneradorDeDatosAleatorio();
        int numero = generador.NumeroAleatorio(100);
        return new Numero(numero);
    }

    public override Comparable CrearPorTeclado()
    {
        int numero = LectorDeDatos.NumeroPorteclado();
        return new Numero(numero);
    }
}
