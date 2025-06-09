using clase1.interfaces;

namespace clase1.models;

public abstract class Persona : Comparable
{
    private string Nombre;
    private int Dni;
    public Persona(string nombre, int dni)
    {
        Nombre = nombre;
        Dni = dni;
    }

    public string GetNombre()
    {
        return Nombre;
    }

    public int GetDni()
    {
        return Dni;
    }
    override public string ToString()
    {
        return GetDni().ToString();
    }

    public virtual bool SosIgual(Comparable c)
    {
        return GetDni() == ((Persona)c).GetDni();
    }
    public virtual bool SosMenor(Comparable c)
    {
        return GetDni() < ((Persona)c).GetDni();
    }
    public virtual bool SosMayor(Comparable c)
    {
        return GetDni() > ((Persona)c).GetDni();
    }
}
