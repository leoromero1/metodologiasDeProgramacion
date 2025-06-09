using clase5.interfaces;
using clase5.models;

namespace clase5.comand;

public class OrdenInicio : OrdenEnAula1
{
    private Aula Aula;
    public OrdenInicio(Aula aula)
    {
        Aula = aula;
    }

    public void Ejecutar()
    {
        Aula.Comenzar();
    }


}
