using Screen_Sound.Models;

namespace Screen_Sound.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.WriteLine("Tchau Tchau  ;)");
        }
        
    }
}
