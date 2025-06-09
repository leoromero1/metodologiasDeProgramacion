using clase5.interfaces;
using clase5.models;

namespace clase5.strategy;

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
