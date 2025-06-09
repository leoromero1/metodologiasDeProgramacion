using clase5.factoryMethod;
using clase5.interfaces;

namespace clase5.proxy;

public class AlumnoEstudioso : IAlumno
{
    private IAlumno? AlumnoReal;

    private string Nombre;

    public AlumnoEstudioso(string nombre)
    {
        Nombre = nombre;
    }
    public int GetCalificacion()
    {
        return AlumnoReal!.GetCalificacion();
    }

    public void SetCalificacion(int calificacion)
    {
        AlumnoReal!.SetCalificacion(calificacion);
    }

    public int ResponderPregunta(int pregunta)
    {

        if (AlumnoReal == null)
        {
            FabricaDeAlumnos fabrica = new FabricaDeAlumnos();
            AlumnoReal = (IAlumno)fabrica.CrearAleatorio();
        }
        return AlumnoReal.ResponderPregunta(pregunta);
    }
    public string MostrarCalificacion()
    {
        return AlumnoReal!.MostrarCalificacion();
    }
    public int GetLegajo()
    {
        return AlumnoReal!.GetLegajo();
    }
    public override string ToString()
    {
        return AlumnoReal!.ToString();
    }
    public void PrestarAtencion()
    {
        AlumnoReal!.PrestarAtencion();
    }
    public void Distraerse()
    {
        AlumnoReal!.Distraerse();
    }
    public void Actualizar(Observado o)
    {
        AlumnoReal!.Actualizar(o);
    }
    public string GetNombre()
    {
        return Nombre;
    }
    public int GetDni()
    {
        return AlumnoReal!.GetDni();
    }
    public float GetPromedio()
    {
        return AlumnoReal!.GetPromedio();
    }

    public bool SosIgual(Comparable c)
    {
        return AlumnoReal!.SosIgual(c);
    }
    public bool SosMenor(Comparable c)
    {
        return AlumnoReal!.SosMenor(c);
    }
    public bool SosMayor(Comparable c)
    {
        return AlumnoReal!.SosMayor(c);
    }
}
