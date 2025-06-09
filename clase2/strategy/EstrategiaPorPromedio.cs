using clase2.interfaces;
using clase2.models;

namespace clase2.strategy;

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
