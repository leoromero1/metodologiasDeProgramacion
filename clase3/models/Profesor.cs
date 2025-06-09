using clase3.interfaces;
using clase3.strategy;

namespace clase3.models;

public class Profesor : Persona, Observado
{
    private int Antiguedad;
    private EstrategiaProfesor Estrategia;
    private List<Observador> Observadores = new List<Observador>();
    public string? Actual;
    public Profesor(string nombre, int dni, int antiguedad) : base(nombre, dni)
    {
        Antiguedad = antiguedad;
        Estrategia = new EstrategiaPorAntiguedad();
    }
    public int GetAntiguedad()
    {
        return Antiguedad;
    }
    public void SetEstrategia(EstrategiaProfesor e)
    {
        Estrategia = e;
    }
    public override string ToString()
    {
        return $"Profesor: {GetNombre()}, DNI: {GetDni()}, Antigüedad: {GetAntiguedad()} años";
    }

    // Practica 3 - ejercicio 12:
    public void HablarALaClase()
    {
        Actual = "Hablar";
        Console.WriteLine("Hablando de algun tema");
        Notificar();
    }

    public void EscribirEnElPizarron()
    {
        Actual = "Escribir";
        Console.WriteLine("Escribiendo en el pizarron");
        Notificar();
    }
    public void AgregarObservador(Observador o)
    {
        Observadores.Add(o);
    }

    public void QuitarObservador(Observador o)
    {
        Observadores.Remove(o);
    }
    public void Notificar()
    {
        foreach (var observador in Observadores)
        {
            observador.Actualizar(this);
        }
    }    

}
