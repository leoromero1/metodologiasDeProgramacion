using clase4.interfaces;

namespace clase4.decorator;

public class DecoradoPorPromocion : AlumnoDecorator
{
    public DecoradoPorPromocion(IAlumno alumno) : base(alumno)
    { }
    public override string MostrarCalificacion()
    {
        int calificacion = GetCalificacion();
        if (calificacion < 4) return base.MostrarCalificacion() + " (DESAPROBADO)";
        if (calificacion >= 4 && calificacion < 7) return base.MostrarCalificacion() + " (APROBADO)";
        return base.MostrarCalificacion() + " (PROMOCIONADO)";
    }
}
