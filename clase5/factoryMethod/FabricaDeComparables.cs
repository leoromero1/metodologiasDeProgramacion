using clase5.interfaces;
using clase5.models;

namespace clase5.factoryMethod;

public abstract class FabricaDeComparables
{
    public static Comparable CrearAleatorio(int opcion)
    {
        FabricaDeComparables? fabrica = null;
        switch (opcion)
        {
            case 1:
                fabrica = new FabricaDeNumeros();
                break;
            case 2:
                fabrica = new FabricaDeAlumnos();
                break;
            case 3:
                fabrica = new FabricaDeProfesores();
                break;
            case 4:
                fabrica = new FabricaDeAlumnosProxy();
                break;
            default:
                throw new ArgumentException("Opción inválida");
        }

        return fabrica!.CrearAleatorio();
    }
    public static Comparable CrearPorTeclado(int opcion)
    {
        FabricaDeComparables fabrica;
        switch (opcion)
        {
            case 1:
                fabrica = new FabricaDeNumeros();
                break;
            case 2:
                fabrica = new FabricaDeAlumnos();
                break;
            case 3:
                fabrica = new FabricaDeProfesores();
                break;
            default:
                throw new ArgumentException("Opción inválida");
        }

        return fabrica.CrearPorTeclado();
    }

    abstract public Comparable CrearAleatorio();
    abstract public Comparable CrearPorTeclado();
}
