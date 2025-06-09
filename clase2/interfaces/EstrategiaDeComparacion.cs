using clase2.models;

namespace clase2.interfaces;

public interface EstrategiaDeComparacion
{
    bool SosIgual(Alumno a1, Alumno a2);
    bool SosMenor(Alumno a1, Alumno a2);
    bool SosMayor(Alumno a1, Alumno a2);
}