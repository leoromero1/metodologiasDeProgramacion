using clase5.models;

namespace clase5.interfaces;

public interface EstrategiaProfesor
{
    bool SosIgual(Profesor p1, Profesor p2);
    bool SosMenor(Profesor p1, Profesor p2);
    bool SosMayor(Profesor p1, Profesor p2);
}
