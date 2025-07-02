namespace clase6.TemplateMethod;


public abstract class JuegoDeCartas
{
    protected Persona? Jugador1, Jugador2;
    private Random Random = new Random();

    public Persona Jugar(Persona jugador1, Persona jugador2)
    {
        Jugador1 = jugador1;
        Jugador2 = jugador2;

        MezclarMazo();
        RepartirCartas(jugador1, jugador2);

        do
        {
            JugarMano(Jugador1);
            if (!HayGanador())
            {
                JugarMano(Jugador2);
            }
        } while (!JuegoTerminado());

        return DeterminarGanador(Jugador1, Jugador2);
    }

    private void JugarMano(Persona jugador)
    {
        TomarCartas(jugador);
        DescartarCartas(jugador);
    }


    protected abstract void MezclarMazo();
    protected abstract void RepartirCartas(Persona jugador1, Persona jugador2);
    protected abstract void TomarCartas(Persona jugador);
    protected abstract void DescartarCartas(Persona jugador);
    protected abstract bool HayGanador();
    protected abstract bool JuegoTerminado();
    protected abstract Persona DeterminarGanador(Persona jugador1, Persona jugador2);

}
