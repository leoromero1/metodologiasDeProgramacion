using clase5.interfaces;

namespace clase5.decorator
{
    public class DecoradorPorLegajo : AlumnoDecorator
    {
        public DecoradorPorLegajo(IAlumno alumno) : base(alumno)
        {
        }

        public override string MostrarCalificacion()
        {

            return $"{Alumno.GetNombre()} ({Alumno.GetLegajo()}/{Alumno.GetCalificacion()})";
        }
    }
}