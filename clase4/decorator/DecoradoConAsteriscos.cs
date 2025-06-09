using clase4.interfaces;

namespace clase4.decorator;

public class DecoradoConAsteriscos : AlumnoDecorator
{
    public DecoradoConAsteriscos(IAlumno alumno) : base(alumno)
    {
    }
    public override string MostrarCalificacion()
    {
        return "********************************************" + "\n"
              + "* " + base.MostrarCalificacion() +"        *" + "\n"
              + "********************************************";
    }
}
