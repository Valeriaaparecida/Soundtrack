using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoundTrackPOO
{
    public class Podcast
    {
        private List<Episodio> episodios = new();

        public string Host { get; }
        public string Nome { get; }

        public int TotalEpisodios => episodios.Count;
        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
        }

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
            
        }
        
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Podcast: {Nome} - Host: {Host} \n");
            foreach (var episodio in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine($"Episódio {episodio.Ordem}: {episodio.Titulo} - {episodio.Duracao} minutos");
            }
            {
                Console.WriteLine(episodio.Resumo);
            }   

    }
}
}