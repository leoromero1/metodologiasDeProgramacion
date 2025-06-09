using clase3.interfaces;
using clase3.models;

namespace clase3.strategy;

public class EstrategiaPorLegajo : EstrategiaDeComparacion
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.GetLegajo() == b.GetLegajo();
    }
    public bool SosMenor(Alumno a, Alumno b)
    {
        return a.GetLegajo() < b.GetLegajo();
    }
    public bool SosMayor(Alumno a, Alumno b)
    {
        return a.GetLegajo() > b.GetLegajo();
    }
}
