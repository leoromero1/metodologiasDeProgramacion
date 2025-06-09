using clase5.interfaces;
using clase5.models;

public class Pila : Coleccionable, Iterable, Ordenable
{
    private List<Comparable> elementos;
    private OrdenEnAula1? OrdenIncio = null, OrdenFin = null;
    private OrdenEnAula2? OrdenAlumno = null;
    public Pila()
    {
        elementos = new List<Comparable>();
    }
    public void Apilar(Comparable c)
    {
        elementos.Add(c);

        //Practica 5 - Ejercicio 9
        if (elementos.Count == 1)
        {
            OrdenIncio?.Ejecutar();
        }
        if (OrdenAlumno != null)
        {
            OrdenAlumno?.Ejecutar(c);
        }
        if (elementos.Count == 40)
        {
            OrdenFin?.Ejecutar();
        }

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

    //Practica 5 - Ejercicio 9

    public void SetOrdenInicio(OrdenEnAula1 a)
    {
        OrdenIncio = a;
    }
    public void SetOrdenLlegaAlumno(OrdenEnAula2 a)
    {
        OrdenAlumno = a;
    }
    public void setOrdenAulaLlena(OrdenEnAula1 a)
    {
        OrdenFin = a;
    }
}
