using System.Collections.Generic;
using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        IEnumerable<Leilao> BuscarLeiloes();

        Leilao BuscarLeilaoPorId(int id);

        void InserirLeilao(Leilao leilao);

        void AtualizaLeilao(Leilao leilao);

        void RemoverLeilao(Leilao leilao);

        IEnumerable<Leilao> ListaLeiloesPorTermo(string termo);
    }
}
