public class Album
{
    private List<Musica> listaMusicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        listaMusicas.Add(musica);
    }
    public void ExibirMusicaDoAlbum()
    {
        Console.WriteLine($"Lista de música do álbum {Nome}. \n");
        foreach(var musica in listaMusicas)
        {
            Console.WriteLine($"Musica: {musica.NomeMusica}");
        }       
        
    }
}