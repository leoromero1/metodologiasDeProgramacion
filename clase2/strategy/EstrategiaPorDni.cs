using clase2.interfaces;
using clase2.models;

namespace clase2.strategy;

public class EstrategiaPorDni : EstrategiaDeComparacion
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.GetDni() == b.GetDni();
    }
    public bool SosMenor(Alumno a, Alumno b)
    {
        return a.GetDni() < b.GetDni();
    }
    public bool SosMayor(Alumno a, Alumno b)
    {
        return a.GetDni() > b.GetDni();
    }
}
