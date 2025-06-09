namespace clase5.interfaces;

public interface IAlumno : Comparable
{
    int GetCalificacion();
    void SetCalificacion(int nuevaCalificacion);
    int ResponderPregunta(int pregunta);
    string MostrarCalificacion();
    int GetLegajo();
    string ToString();
    void PrestarAtencion();
    void Distraerse();
    void Actualizar(Observado o);
    string GetNombre();
    int GetDni();
    float GetPromedio();
}