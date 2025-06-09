using clase4.interfaces;
namespace clase4.models;

public class IteradorGeneral : Iterador
{
    private List<Comparable> Elementos;
    private int posicionActual;
    public IteradorGeneral(List<Comparable> elementos)
    {
        Elementos = elementos;
        posicionActual = 0;
    }

    public void Primero()
    {
        posicionActual = 0;
    }

    public void Siguiente()
    {
        posicionActual++;
    }
    public bool Fin()
    {
        return posicionActual >= Elementos.Count;
    }
    public Comparable Actual()
    {
        return Elementos[posicionActual];
    }
}
