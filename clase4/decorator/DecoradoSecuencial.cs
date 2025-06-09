using clase4.interfaces;

namespace clase4.decorator;

public class DecoradoSecuencial : AlumnoDecorator
{
    private static int contador = 1;
    private int NumeroOrden;

    public DecoradoSecuencial(IAlumno alumno) : base(alumno)
    {
        NumeroOrden = contador++;
    }

    public override string MostrarCalificacion()
    {
        return $"{NumeroOrden}) {GetNombre()} {GetCalificacion()}";
    }
}
