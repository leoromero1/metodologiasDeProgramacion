using System;
using clase6;
using clase6.TemplateMethod;

public class Juego1 : JuegoDeCartas
{
    private int rondasJugadas = 0;
    private int victoriasJugador1 = 0;
    private int victoriasJugador2 = 0;
    private Random random = new Random();

    protected override void MezclarMazo()
    {
        Console.WriteLine("Mezclando el mazo...");
    }

    protected override void RepartirCartas(Persona jugador1, Persona jugador2)
    {
        Console.WriteLine("Repartiendo cartas...");
        Console.WriteLine("");
    }

    protected override void TomarCartas(Persona jugador)
    {
        Console.WriteLine($"{jugador.GetNombre()} toma una carta...");
    }

    protected override void DescartarCartas(Persona jugador)
    {
        jugador.CartaDescartada = random.Next(1, 11);
        Console.WriteLine($"{jugador.GetNombre()} tira un {jugador.CartaDescartada}");
    }

    protected override bool HayGanador()
    {
        return victoriasJugador1 == 2 || victoriasJugador2 == 2;
    }

    protected override bool JuegoTerminado()
    {
        rondasJugadas++;
        Console.WriteLine($"Ronda {rondasJugadas} terminada.");


        if (Jugador1!.CartaDescartada > Jugador2!.CartaDescartada)
        {
            victoriasJugador1++;
            Console.WriteLine($"{Jugador1.GetNombre()} gana la ronda.");
        }
        else if (Jugador2!.CartaDescartada > Jugador1!.CartaDescartada)
        {
            victoriasJugador2++;
            Console.WriteLine($"{Jugador2.GetNombre()} gana la ronda.");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Empate en la ronda.");
        }
        Console.WriteLine("");

        return HayGanador() || rondasJugadas >= 3;
    }

    protected override Persona DeterminarGanador(Persona jugador1, Persona jugador2)
    {
        Console.WriteLine("Juego terminado.");
        if (victoriasJugador1 > victoriasJugador2)
            return jugador1;

        return jugador2;
    }
}
