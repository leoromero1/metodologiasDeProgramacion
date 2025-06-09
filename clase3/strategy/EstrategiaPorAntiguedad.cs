using clase3.interfaces;
using clase3.models;

namespace clase3.strategy;

public class EstrategiaPorAntiguedad : EstrategiaProfesor
{
    public bool SosIgual(Profesor p1, Profesor p2)
    {
        return p1.GetAntiguedad() == p2.GetAntiguedad();
    }

    public bool SosMenor(Profesor p1, Profesor p2)
    {
        return p1.GetAntiguedad() < p2.GetAntiguedad();
    }

    public bool SosMayor(Profesor p1, Profesor p2)
    {
        return p1.GetAntiguedad() > p2.GetAntiguedad();
    }
}
