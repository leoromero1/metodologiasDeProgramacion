using clase2.interfaces;
using clase2.models;

namespace clase2.strategy;

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
