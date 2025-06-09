using clase3.interfaces;
using clase3.models;

public class Pila : Coleccionable, Iterable
{
    private List<Comparable> elementos;

    public Pila()
    {
        elementos = new List<Comparable>();
    }
    public void Apilar(Comparable c)
    {
        elementos.Add(c);
    }

    public Comparable Desapilar()
    {
        Comparable aux = elementos[elementos.Count - 1];
        elementos.RemoveAt(elementos.Count - 1);
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
        Apilar(c);
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
