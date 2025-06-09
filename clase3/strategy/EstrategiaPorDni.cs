using clase3.interfaces;
using clase3.models;

namespace clase3.strategy;

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
