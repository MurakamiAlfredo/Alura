using System.Collections.Generic;
using System.Linq;
using Alura.LeilaoOnline.WebApp.Models;


namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ICategoriaDao
    {
        IEnumerable<Categoria> BuscarCategorias();

        Categoria BuscarCategoriaPorId(int id);

        IEnumerable<Categoria> ListaCategoriasLeiloes();
    }
}
