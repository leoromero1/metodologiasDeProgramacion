using clase6;
using clase6.TemplateMethod;
class Program
{
    static void Main(string[] args)
    {
        //Practica 6 ejercio 5
        /*
        //juego 1
        Persona jugador1 = new Persona("Leo");
        Persona jugador2 = new Persona("Martín");
        JuegoDeCartas juego1 = new Juego1();
        Persona ganador = juego1.Jugar(jugador1, jugador2);

        Console.WriteLine($"El ganador es: {ganador.GetNombre()}");

        */

        // juego 2
        Persona jugador3 = new Persona("Leo");
        Persona jugador4 = new Persona("Dario");
        JuegoDeCartas juego2 = new Juego2();
        Persona ganador = juego2.Jugar(jugador3, jugador4);
        Console.WriteLine($"El ganador es: {ganador.GetNombre()}");
    }
}
