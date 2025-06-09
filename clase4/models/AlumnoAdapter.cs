using clase4.interfaces;
using MetodologíasDeProgramaciónI;

namespace clase4.models;

public class AlumnoAdapter : Student
{
    private IAlumno Alumno;
    public AlumnoAdapter(IAlumno alumno)
    {
        Alumno = alumno;
    }
    public string getName()
    {
        return Alumno.GetNombre();
    }

    public int yourAnswerIs(int question)
    {
        return Alumno.ResponderPregunta(question);
    }

    public void setScore(int score)
    {
        Alumno.SetCalificacion(score);
    }
    public string showResult()
    {
        return Alumno.MostrarCalificacion();
    }
    public bool equals(Student student)
    {
        return Alumno.SosIgual(((AlumnoAdapter)student).Alumno);
    }
    public bool lessThan(Student student)
    {
        return Alumno.SosMenor(((AlumnoAdapter)student).Alumno);
    }
    public bool greaterThan(Student student)
    {
        return Alumno.SosMayor(((AlumnoAdapter)student).Alumno);
    }
}
