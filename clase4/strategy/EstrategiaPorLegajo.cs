using clase4.interfaces;
using clase4.models;

namespace clase4.strategy;

public class EstrategiaPorLegajo : EstrategiaDeComparacion
{
    public bool SosIgual(IAlumno a, IAlumno b)
    {
        return a.GetLegajo() == b.GetLegajo();
    }
    public bool SosMenor(IAlumno a, IAlumno b)
    {
        return a.GetLegajo() < b.GetLegajo();
    }
    public bool SosMayor(IAlumno a, IAlumno b)
    {
        return a.GetLegajo() > b.GetLegajo();
    }
}
