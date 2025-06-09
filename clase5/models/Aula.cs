using clase5.interfaces;
using MetodologíasDeProgramaciónI;

namespace clase5.models;

public class Aula
{
    private Teacher? teacher;

    public void Comenzar()
    {
        Console.WriteLine("Nuevo Teacher");
        teacher = new Teacher();
    }
    public void NuevoAlumno(IAlumno a)
    {
        teacher?.goToClass(new AlumnoAdapter(a));
    }
    public void ClaseLista()
    {
        teacher?.teachingAClass();
    }

}
