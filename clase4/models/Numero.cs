using clase4.interfaces;

namespace clase4.models;

public class Numero : Comparable
{
    private int Valor;
    public Numero(int valor)
    {
        Valor = valor;
    }
    override public string ToString()
    {
        return GetValor().ToString();
    }
    public int GetValor()
    {
        return Valor;
    }
    public bool SosIgual(Comparable c)
    {
        return Valor == ((Numero)c).GetValor();
    }
    public bool SosMenor(Comparable c)
    {
        return Valor < ((Numero)c).GetValor();
    }
    public bool SosMayor(Comparable c)
    {
        return Valor > ((Numero)c).GetValor();

    }
}