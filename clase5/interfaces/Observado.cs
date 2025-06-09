namespace clase5.interfaces;

public interface Observado
{
    void AgregarObservador(Observador o);
    void QuitarObservador(Observador o);
    void Notificar();
}
