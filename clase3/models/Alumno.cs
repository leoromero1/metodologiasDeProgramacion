
using clase3.interfaces;
using clase3.strategy;

namespace clase3.models;

public class Alumno : Persona, Observador
{
    private int Legajo;
    private float Promedio;
    private EstrategiaDeComparacion Estrategia;
    public Alumno(string nombre, int dni, int legajo, float promedio) : base(nombre, dni)
    {
        Legajo = legajo;
        Promedio = promedio;
        Estrategia = new EstrategiaPorPromedio();
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
        return $"Alumno: {GetNombre()} - DNI: {GetDni()} - Legajo: {GetLegajo()} - Promedio: {GetPromedio():0.00}";
    }

    public void SetEstrategia(EstrategiaDeComparacion estrategia)
    {
        Estrategia = estrategia;
    }

    //practica 1- ejercicio 15:
    public override bool SosIgual(Comparable c)
    {
        return Estrategia.SosIgual(this, (Alumno)c);
    }
    public override bool SosMenor(Comparable c)
    {
        return Estrategia.SosMenor(this, (Alumno)c);
    }
    public override bool SosMayor(Comparable c)
    {
        return Estrategia.SosMayor(this, (Alumno)c);
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
    
}
