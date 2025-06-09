
using clase2.interfaces;
using clase2.strategy;

namespace clase2.models;

public class Alumno : Persona
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

}
