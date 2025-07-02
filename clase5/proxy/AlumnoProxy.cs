using clase5.factoryMethod;
using clase5.interfaces;

namespace clase5.proxy;

public class AlumnoProxy : IAlumno
{
    private IAlumno? AlumnoReal = null;
    private string Nombre;

    public AlumnoProxy(string nombre)
    {
        Nombre = nombre;
    }
    public int GetCalificacion()
    {
        if (AlumnoReal == null)
        {
            AlumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(2);
        }
        return AlumnoReal.GetCalificacion();
    }

    public void SetCalificacion(int calificacion)
    {
        if (AlumnoReal == null)
        {
            AlumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(2);
        }
        AlumnoReal.SetCalificacion(calificacion);
    }

    public int ResponderPregunta(int pregunta)
    {
        if (AlumnoReal == null)
        {
            AlumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(2);
        }
        return AlumnoReal.ResponderPregunta(pregunta);
    }
    public string MostrarCalificacion()
    {
        if (AlumnoReal == null)
        {
            AlumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(2);
        }
        return $"(Proxy) {AlumnoReal.MostrarCalificacion()}";
    }
    public int GetLegajo()
    {
        if (AlumnoReal == null)
        {
            AlumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(2);
        }
        return AlumnoReal.GetLegajo();
    }
    public override string ToString()
    {
        if (AlumnoReal == null)
        {
            AlumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(2);
        }
        return AlumnoReal.ToString();
    }
    public void PrestarAtencion()
    {
        if (AlumnoReal == null)
        {
            AlumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(2);
        }
        AlumnoReal.PrestarAtencion();
    }
    public void Distraerse()
    {
        if (AlumnoReal == null)
        {
            AlumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(2);
        }
        AlumnoReal.Distraerse();
    }
    public void Actualizar(Observado o)
    {
        if (AlumnoReal == null)
        {
            AlumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(2);
        }
        AlumnoReal.Actualizar(o);
    }
    public string GetNombre()
    {
        return Nombre;
    }
    public int GetDni()
    {
        if (AlumnoReal == null)
        {
            AlumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(2);
        }
        return AlumnoReal.GetDni();
    }
    public float GetPromedio()
    {
        if (AlumnoReal == null)
        {
            AlumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(2);
        }
        return AlumnoReal.GetPromedio();
    }

    public bool SosIgual(Comparable c)
    {
        if (AlumnoReal == null)
        {
            AlumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(2);
        }
        return AlumnoReal.SosIgual(c);
    }
    public bool SosMenor(Comparable c)
    {
        if (AlumnoReal == null)
        {
            AlumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(2);
        }
        return AlumnoReal.SosMenor(c);
    }
    public bool SosMayor(Comparable c)
    {
        if (AlumnoReal == null)
        {
            AlumnoReal = (IAlumno)FabricaDeComparables.CrearAleatorio(2);
        }
        return AlumnoReal.SosMayor(c);
    }
}
