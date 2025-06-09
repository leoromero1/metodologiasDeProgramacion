

namespace clase5.interfaces;

public interface EstrategiaDeComparacion
{
    bool SosIgual(IAlumno a1, IAlumno a2);
    bool SosMenor(IAlumno a1, IAlumno a2);
    bool SosMayor(IAlumno a1, IAlumno a2);
}