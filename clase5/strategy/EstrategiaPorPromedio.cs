using clase5.interfaces;
using clase5.models;

namespace clase5.strategy;

public class EstrategiaPorPromedio : EstrategiaDeComparacion
{
    public bool SosIgual(IAlumno a, IAlumno b)
    {
        return a.GetPromedio() == b.GetPromedio();
    }

    public bool SosMenor(IAlumno a, IAlumno b)
    {
        return a.GetPromedio() < b.GetPromedio();
    }

    public bool SosMayor(IAlumno a, IAlumno b)
    {
        return a.GetPromedio() > b.GetPromedio();
    }
}
