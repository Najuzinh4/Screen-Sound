using Screen_Sound.Models;
namespace Screen_Sound.Menus;

internal class MenuRegistrarBanda : Menu

{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        //bandasRegistradas.Add(nomeDaBanda,
        //                      new List<Avaliacao>());
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }

}
