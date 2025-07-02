namespace clase6;

public class Persona
{
    private string Nombre;
    public int CartaDescartada { get; set; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }
    public string GetNombre()
    {
        return Nombre;
    }
}
