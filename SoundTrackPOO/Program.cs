﻿using SoundTrackPOO;

Episodio episodio1 = new Episodio(1, "Técnicas de facilitação", 45);
episodio1.AdicionarConvidados("Maia");
episodio1.AdicionarConvidados("Luca");

Episodio episodio2 = new Episodio(1, "Técnicas de aprendizado", 65);
episodio1.AdicionarConvidados("Maria");
episodio1.AdicionarConvidados("Luzia");

Podcast podcast = new Podcast("Luca", "Facilitando o futuro");
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.ExibirDetalhes();