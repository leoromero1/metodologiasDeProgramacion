using clase4.interfaces;

namespace clase4.models;

public class ColeccionMultiple : Coleccionable
{
    private Pila Pila;
    private Cola Cola;
    public ColeccionMultiple(Pila pila, Cola cola)
    {
        Pila = pila;
        Cola = cola;
    }

    public int Cuantos()
    {
        return Pila.Cuantos() + Cola.Cuantos();
    }
    public Comparable Minimo()
    {
        Comparable minimoP = Pila.Minimo();
        Comparable minimoC = Cola.Minimo();
        if (minimoP.SosMenor(minimoC))
        {
            return minimoP;
        }
        return minimoC;
    }
    public Comparable Maximo()
    {
        Comparable maximoP = Pila.Maximo();
        Comparable maximoC = Cola.Maximo();
        if (maximoP.SosMayor(maximoC))
        {
            return maximoP;
        }
        return maximoC;
    }
    public void Agregar(Comparable c)
    {

    }
    public bool Contiene(Comparable c)
    {
        if (Pila.Contiene(c) || Cola.Contiene(c))
        {
            return true;
        }
        return false;
    }
}
