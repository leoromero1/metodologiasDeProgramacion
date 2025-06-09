using clase3.interfaces;

namespace clase3.models;

public class Cola : Coleccionable, Iterable
{
    private List<Comparable> elementos;

    public Cola()
    {
        elementos = new List<Comparable>();
    }

    public void Encolar(Comparable c)
    {
        elementos.Add(c);
    }

    public Comparable Desencolar()
    {
        Comparable aux = elementos[0];
        elementos.RemoveAt(0);
        return aux;
    }

    public int Cuantos()
    {
        return elementos.Count;
    }
    public Comparable Minimo()
    {
        Comparable MasChico = elementos[0];
        for (int i = 1; i < Cuantos(); i++)
        {
            if (elementos[i].SosMenor(MasChico))
            {
                MasChico = elementos[i];
            }
        }
        return MasChico;
    }
    public Comparable Maximo()
    {
        Comparable MasGrande = elementos[0];
        for (int i = 1; i < Cuantos(); i++)
        {
            if (elementos[i].SosMayor(MasGrande))
            {
                MasGrande = elementos[i];
            }
        }
        return MasGrande;
    }
    public void Agregar(Comparable c)
    {
        Encolar(c);
    }
    public bool Contiene(Comparable c)
    {
        for (int i = 0; i < Cuantos(); i++)
        {
            if (elementos[i].SosIgual(c))
            {
                return true;
            }
        }
        return false;
    }
    public Iterador CrearIterador()
    {
        return new IteradorGeneral(elementos);
    }
}
