using clase6;
using clase6.TemplateMethod;

public class Juego2 : JuegoDeCartas
{
    private Random random = new Random();
    private int puntosJugador1 = 0;
    private int puntosJugador2 = 0;

    protected override void MezclarMazo()
    {
        Console.WriteLine("Mezclando...");
    }

    protected override void RepartirCartas(Persona jugador1, Persona jugador2)
    {
        Console.WriteLine("Comienza el juego");
    }

    protected override void TomarCartas(Persona jugador)
    {
        int carta = random.Next(1, 6);
        jugador.CartaDescartada = carta;

        if (jugador == Jugador1)
            puntosJugador1 += carta;
        else
            puntosJugador2 += carta;

        Console.WriteLine($"{jugador.GetNombre()} robó un {carta}");
    }

    protected override void DescartarCartas(Persona jugador)
    {
        int puntos = jugador == Jugador1 ? puntosJugador1 : puntosJugador2;
        Console.WriteLine($"{jugador.GetNombre()} tiene ahora {puntos} puntos.");
    }

    protected override bool HayGanador()
    {
        return puntosJugador1 >= 10 || puntosJugador2 >= 10;
    }

    protected override bool JuegoTerminado()
    {
        return HayGanador();
    }

    protected override Persona DeterminarGanador(Persona jugador1, Persona jugador2)
    {
        Console.WriteLine("Juego terminado.");
        Console.WriteLine($"{jugador1.GetNombre()} tiene {puntosJugador1} puntos.");
        Console.WriteLine($"{jugador2.GetNombre()} tiene {puntosJugador2} puntos.");

        if (puntosJugador1 > puntosJugador2)
            return jugador1;
        return jugador2;
    }
}