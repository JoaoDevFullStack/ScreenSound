
namespace ScreenSound.Models;

internal interface IRate
{
    void AdicionarNota(Avaliacao nota);
    double Media { get; }

    
}
