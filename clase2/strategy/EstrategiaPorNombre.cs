using clase2.interfaces;
using clase2.models;

namespace clase2.strategy;

public class EstrategiaPorNombre : EstrategiaDeComparacion
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.GetNombre() == b.GetNombre();
    }

    public bool SosMenor(Alumno a, Alumno b)
    {
        return string.Compare(a.GetNombre(), b.GetNombre()) < 0;
    }

    public bool SosMayor(Alumno a, Alumno b)
    {
        return string.Compare(a.GetNombre(), b.GetNombre()) > 0;
    }
}
