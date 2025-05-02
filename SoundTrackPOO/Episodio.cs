using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoundTrackPOO
{


    public class Episodio
    {
        private List<string> _convidados = new();
        public int Duracao { get; }
        public int Ordem { get; }
        public string? Titulo { get; }
        public string? Resumo => $"{Ordem}.{Titulo} {Duracao} minutos -{string.Join(", ", _convidados)}";
        
        public Episodio(int ordem, string titulo, int duracao)
        {
            Ordem = ordem;
            Titulo = titulo;
            Duracao = duracao;
        }

        public void AdicionarConvidados(string convidado)
        {
            _convidados.Add(convidado);
        }
      
    }
}