using clase5.interfaces;
using clase5.models;

namespace clase5.comand;

public class OrdenAulaLlena : OrdenEnAula1
{
    private Aula Aula;

    public OrdenAulaLlena(Aula aula)
    {
        Aula = aula;
    }

    public void Ejecutar()
    {
        Aula.ClaseLista();
    }
}
