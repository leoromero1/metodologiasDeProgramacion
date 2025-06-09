using clase3.interfaces;
using clase3.models;

namespace clase3.strategy;

public class EstrategiaPorPromedio : EstrategiaDeComparacion
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.GetPromedio() == b.GetPromedio();
    }

    public bool SosMenor(Alumno a, Alumno b)
    {
        return a.GetPromedio() < b.GetPromedio();
    }

    public bool SosMayor(Alumno a, Alumno b)
    {
        return a.GetPromedio() > b.GetPromedio();
    }
}
