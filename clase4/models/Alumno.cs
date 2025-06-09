
using clase4.interfaces;
using clase4.strategy;

namespace clase4.models;

public class Alumno : Persona, Observador, IAlumno
{
    private int Legajo;
    private float Promedio;
    private EstrategiaDeComparacion Estrategia;
    private int Calificacion;
    public Alumno(string nombre, int dni, int legajo, float promedio, int calificacion) : base(nombre, dni)
    {
        Legajo = legajo;
        Promedio = promedio;
        Estrategia = new EstrategiaPorPromedio();
        Calificacion = calificacion;
    }

    public int GetLegajo()
    {
        return Legajo;
    }
    public float GetPromedio()
    {
        return Promedio;
    }

    public override string ToString()
    {
        return $"Alumno: {GetNombre()} - DNI: {GetDni()} - Legajo: {GetLegajo()} - Promedio: {GetPromedio():0.00}, Calificación: {Calificacion}";
    }

    public void SetEstrategia(EstrategiaDeComparacion estrategia)
    {
        Estrategia = estrategia;
    }

    //practica 1- ejercicio 15:
    public override bool SosIgual(Comparable c)
    {
        return Estrategia.SosIgual(this, (IAlumno)c);
    }
    public override bool SosMenor(Comparable c)
    {
        return Estrategia.SosMenor(this, (IAlumno)c);
    }
    public override bool SosMayor(Comparable c)
    {
        return Estrategia.SosMayor(this, (IAlumno)c);
    }
    //practica 3 - ejercicio 11:
    public void PrestarAtencion()
    {
        Console.WriteLine("Prestando atención");
    }
    public virtual void Distraerse()
    {
        Random random = new Random();
        string[] palabara = ["Mirando el celular", "Dibujando en el margen de la carpeta", "tirando aviones de papel"];
        int i = random.Next(0, palabara.Length);
        Console.WriteLine(palabara[i]);
    }
    // Practica 3 - ejercicio 12:
    public void Actualizar(Observado o)
    {
        if (o is Profesor profesor)
        {
            if (profesor.Actual == "Hablar")
            {
                PrestarAtencion();

            }
            else if (profesor.Actual == "Escribir")
            {
                Distraerse();
            }
        }
    }

    //Practica 4 - ejercicio 1

    public int GetCalificacion()
    {
        return Calificacion;
    }
    public void SetCalificacion(int calificacion)
    {
        Calificacion = calificacion;
    }

    public virtual int ResponderPregunta(int pregunta)
    {
        Random random = new Random();
        int respuesta = random.Next(1, 4);
        return respuesta;
    }

    public string MostrarCalificacion()
    {
        return $"{GetNombre()}\t{GetCalificacion()}";
    }
}
