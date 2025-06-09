namespace clase4.models;

public class AlumnoMuyEstudioso : Alumno
{
    public AlumnoMuyEstudioso(string nombre, int dni, int legajo, float promedio, int calificacion) : base(nombre, dni, legajo, promedio, calificacion)
    {
    }

    public override int ResponderPregunta(int pregunta)
    {
        return pregunta % 3;
    }
}
