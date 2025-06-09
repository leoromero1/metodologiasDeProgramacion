using clase4.interfaces;
using clase4.models;

namespace clase4.strategy;

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
