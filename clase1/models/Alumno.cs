
using clase1.interfaces;

namespace clase1.models;

public class Alumno : Persona
{
    private int Legajo;
    private float Promedio;
    public Alumno(string nombre, int dni, int legajo, float promedio) : base(nombre, dni)
    {
        Legajo = legajo;
        Promedio = promedio;
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


    //practica 1- ejercicio 15:
    public override bool SosIgual(Comparable c)
    {
        return GetLegajo() == ((Alumno)c).GetLegajo();
    }
    public override bool SosMenor(Comparable c)
    {
        return GetLegajo() < ((Alumno)c).GetLegajo();
    }
    public override bool SosMayor(Comparable c)
    {
        return GetLegajo() > ((Alumno)c).GetLegajo();
    }
}
