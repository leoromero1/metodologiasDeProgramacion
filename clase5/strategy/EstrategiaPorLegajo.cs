using clase5.interfaces;
using clase5.models;

namespace clase5.strategy;

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
