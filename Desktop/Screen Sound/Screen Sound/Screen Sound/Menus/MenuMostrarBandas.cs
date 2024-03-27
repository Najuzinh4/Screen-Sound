using Screen_Sound.Models;

namespace Screen_Sound.Menus;

internal class MenuMostrarBandas : Menu
{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        throw new NotImplementedException();
    }

    void MostrarBandasRegistradas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

    }
}
