using clase4.interfaces;
using clase4.models;

namespace clase4.strategy;

public class EstrategiaPorDni : EstrategiaDeComparacion
{
    public bool SosIgual(IAlumno a, IAlumno b)
    {
        return a.GetDni() == b.GetDni();
    }
    public bool SosMenor(IAlumno a, IAlumno b)
    {
        return a.GetDni() < b.GetDni();
    }
    public bool SosMayor(IAlumno a, IAlumno b)
    {
        return a.GetDni() > b.GetDni();
    }
}
