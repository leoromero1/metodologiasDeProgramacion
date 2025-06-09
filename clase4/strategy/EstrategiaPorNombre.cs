using clase4.interfaces;
using clase4.models;

namespace clase4.strategy;

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
