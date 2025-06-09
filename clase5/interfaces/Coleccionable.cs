namespace clase5.interfaces;
public interface Coleccionable
{
    int Cuantos();
    Comparable Minimo();
    Comparable Maximo();
    void Agregar(Comparable c);
    bool Contiene(Comparable c);
}
