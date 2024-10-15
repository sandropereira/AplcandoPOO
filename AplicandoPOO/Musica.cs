public class Musica
{
    public string NomeMusica { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {NomeMusica} é do artista {Artista}";
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {NomeMusica}");
        Console.WriteLine($"Artista: {Artista}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus");
        }
    }   
   
}