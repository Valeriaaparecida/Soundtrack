﻿

using Sountrack;

Banda linkinPark = new Banda("Linkin Park");

Album albumDoLinkinPark = new Album("Hybrid Theory");

Musica musica1 = new Musica(linkinPark, "In the End")
{
    Duracao = 213,
    Disponivel = true
};

Musica musica2 = new Musica(linkinPark, "Crawling")
{
    Duracao = 354,
    Disponivel = false
};

albumDoLinkinPark.AdicionarMusica(musica1);
albumDoLinkinPark.AdicionarMusica(musica2);
linkinPark.AdicionarAlbum(albumDoLinkinPark);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoLinkinPark.ExibirMusicasDoAlbum();
linkinPark.ExibirDiscografia();