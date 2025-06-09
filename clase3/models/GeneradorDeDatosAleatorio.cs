namespace clase3.models;

public class GeneradorDeDatosAleatorio
{
    Random random = new Random();
    public int NumeroAleatorio(int max)
    {   
        return random.Next(0, max);
    }
    public string StringAleatorio(int cant)
    {
        string letras = "abcdefghijklmnopqrstuvwxyz";
        string resultado = "";
        for (int i = 0; i < cant; i++)
        {
            int indece = random.Next(0, letras.Length);
            resultado += letras[indece];
        }
        return resultado;
    }
}
