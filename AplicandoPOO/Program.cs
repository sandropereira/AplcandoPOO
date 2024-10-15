var albumDoMamonasAssassinas = new Album();
albumDoMamonasAssassinas.Nome = "Mamonas Eterno";  

Musica musica1 = new Musica();
musica1.NomeMusica = "Pelados em Santos";

Musica musica2 = new Musica();
musica2.NomeMusica = "Vira-Vira";

albumDoMamonasAssassinas.AdicionarMusica(musica1);
albumDoMamonasAssassinas.AdicionarMusica(musica2);
albumDoMamonasAssassinas.ExibirMusicaDoAlbum();