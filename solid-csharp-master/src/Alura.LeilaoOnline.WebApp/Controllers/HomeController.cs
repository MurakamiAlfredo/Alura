using Microsoft.AspNetCore.Mvc;
using Alura.LeilaoOnline.WebApp.Dados;
using Microsoft.AspNetCore.Routing;

namespace Alura.LeilaoOnline.WebApp.Controllers
{
    public class HomeController : Controller
    {
        LeilaoDao _daoLeilao;
        CategoriaDao _daoCategoria;

        public HomeController()
        {
            _daoLeilao = new LeilaoDao();
            _daoCategoria = new CategoriaDao();
        }

        public IActionResult Index()
        {
            var categorias = _daoCategoria.ListaCategoriasLeiloes();
            return View(categorias);
        }

        [Route("[controller]/StatusCode/{statusCode}")]
        public IActionResult StatusCodeError(int statusCode)
        {
            if (statusCode == 404) return View("404");
            return View(statusCode);
        }

        [Route("[controller]/Categoria/{categoria}")]
        public IActionResult Categoria(int categoria)
        {
            var categ = _daoCategoria.BuscarCategoriaPorId(categoria);
            return View(categ);
        }

        [HttpPost]
        [Route("[controller]/Busca")]
        public IActionResult Busca(string termo)
        {
            ViewData["termo"] = termo;
            var termoNormalized = termo.ToUpper();
            var leiloes = _daoLeilao.ListaLeiloesPorTermo(termoNormalized);
            return View(leiloes);
        }
    }
}
