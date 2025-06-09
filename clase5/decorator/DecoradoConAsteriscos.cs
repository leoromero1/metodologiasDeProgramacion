using clase5.interfaces;

namespace clase5.decorator;

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
