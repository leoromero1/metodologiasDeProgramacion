using clase5.interfaces;
using clase5.models;

namespace clase5.strategy;

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
