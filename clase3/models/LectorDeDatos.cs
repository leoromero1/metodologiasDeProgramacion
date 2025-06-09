namespace clase3.models;

public class LectorDeDatos
{
    public static int NumeroPorteclado()
    {
        Console.WriteLine("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine()!);
        return numero;
    }

    public static string TextoPorteclado()
    {
        Console.WriteLine("Ingrese un texto: ");
        string texto = Console.ReadLine()!;
        return texto;
    }
}
