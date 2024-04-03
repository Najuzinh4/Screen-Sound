namespace Screen_Sound.Models
{
    internal interface IAvaliavel
    {
        //A palavra interface significa que o que eu vou ter entre as chaves não é um código executèvel
        void AdicionarNota(Avaliacao nota);
        double Media { get; }
    }
}
