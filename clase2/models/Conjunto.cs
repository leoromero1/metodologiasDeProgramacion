using clase2.interfaces;

namespace clase2.models;

public class Conjunto : Coleccionable, Iterable
{
    private List<Comparable> elementos;

    public Conjunto()
    {
        elementos = new List<Comparable>();
    }

    public bool Pertenece(Comparable c)
    {
        foreach (Comparable item in elementos)
        {
            if (item.SosIgual(c)) return true;
        }
        return false;
    }

    public void Agregar(Comparable c)
    {
        if (!Pertenece(c))
        {
            elementos.Add(c);
        }
    }

    public int Cuantos()
    {
        return elementos.Count;
    }
    public Comparable Minimo()
    {
        Comparable minimo = elementos[0];
        foreach (Comparable item in elementos)
        {
            if (item.SosMenor(minimo))
                minimo = item;
        }
        return minimo;
    }
    public Comparable Maximo()
    {
        Comparable maximo = elementos[0];
        foreach (Comparable item in elementos)
        {
            if (item.SosMayor(maximo))
                maximo = item;
        }
        return maximo;
    }

    public bool Contiene(Comparable c)
    {
        return Pertenece(c);
    }

    public Iterador CrearIterador()
    {
        return new IteradorGeneral(elementos);
    }
}
