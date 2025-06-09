using clase5.interfaces;
using clase5.models;

namespace clase5.comand;

public class OrdenLlegaAlumno : OrdenEnAula2
{
    private Aula Aula;
    public OrdenLlegaAlumno(Aula aula)
    {
        Aula = aula;
    }
    public void Ejecutar(Comparable c)
    {
        Aula.NuevoAlumno((IAlumno)c);
    }
}