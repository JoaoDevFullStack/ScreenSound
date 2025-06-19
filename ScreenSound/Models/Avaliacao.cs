
namespace ScreenSound.Models;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
        if (nota <= 0) nota = 0;
        if (nota > 10) nota = 10;
    }
    public int Nota { get; }

    public static Avaliacao Parse(string text) {
        int nota = int.Parse(text);
        return new Avaliacao(nota);
    }
}

// O termo internal é usado para restringir o acesso à classe Avaliacao apenas dentro do assembly atual.
// Isso significa que outras partes do código fora deste assembly não poderão acessar essa classe, o que é útil para encapsular a lógica e proteger a implementação interna.
// Método estático é um método que pertence à classe em si, em vez de a uma instância específica da classe. Ele pode ser chamado sem criar uma instância da classe.
