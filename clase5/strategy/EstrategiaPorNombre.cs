using clase5.interfaces;
using clase5.models;

namespace clase5.strategy;

public class EstrategiaPorNombre : EstrategiaDeComparacion
{
    public bool SosIgual(IAlumno a, IAlumno b)
    {
        return a.GetNombre() == b.GetNombre();
    }

    public bool SosMenor(IAlumno a, IAlumno b)
    {
        return string.Compare(a.GetNombre(), b.GetNombre()) < 0;
    }

    public bool SosMayor(IAlumno a, IAlumno b)
    {
        return string.Compare(a.GetNombre(), b.GetNombre()) > 0;
    }
}
