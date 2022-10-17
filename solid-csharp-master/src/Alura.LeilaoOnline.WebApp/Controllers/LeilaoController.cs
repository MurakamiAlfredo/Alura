using Microsoft.AspNetCore.Mvc;
using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System;

namespace Alura.LeilaoOnline.WebApp.Controllers
{
    public class LeilaoController : Controller
    {
        LeilaoDao _daoLeilao;
        CategoriaDao _daoCategoria;
       
        public LeilaoController()
        {
            _daoLeilao = new LeilaoDao();
            _daoCategoria = new CategoriaDao();
        }

        public IActionResult Index()
        {
            var leiloes = _daoLeilao.BuscarLeiloes();
            return View(leiloes);
        } 

        [HttpGet]
        public IActionResult Insert()
        {
            ViewData["Categorias"] = _daoCategoria.BuscarCategorias();
            ViewData["Operacao"] = "Inclusão";
            return View("Form");
        }

        [HttpPost]
        public IActionResult Insert(Leilao model)
        {
            if (ModelState.IsValid)
            {
                _daoLeilao.InserirLeilao(model);
                return RedirectToAction("Index");
            }
            ViewData["Categorias"] = _daoCategoria.BuscarCategorias();
            ViewData["Operacao"] = "Inclusão";
            return View("Form", model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewData["Categorias"] = _daoCategoria.BuscarCategorias();
            ViewData["Operacao"] = "Edição";
            var leilao = _daoLeilao.BuscarLeilaoPorId(id);
            if (leilao == null) return NotFound();
            return View("Form", leilao);
        }

        [HttpPost]
        public IActionResult Edit(Leilao model)
        {
            if (ModelState.IsValid)
            {
                _daoLeilao.AtualizaLeilao(model);
                return RedirectToAction("Index");
            }
            ViewData["Categorias"] = _daoCategoria.BuscarCategorias();
            ViewData["Operacao"] = "Edição";
            return View("Form", model);
        }

        [HttpPost]
        public IActionResult Inicia(int id)
        {
            var leilao = _daoLeilao.BuscarLeilaoPorId(id);
            if (leilao == null) return NotFound();
            if (leilao.Situacao != SituacaoLeilao.Rascunho) return StatusCode(405);
            leilao.Situacao = SituacaoLeilao.Pregao;
            leilao.Inicio = DateTime.Now;
            _daoLeilao.AtualizaLeilao(leilao);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Finaliza(int id)
        {
            var leilao = _daoLeilao.BuscarLeilaoPorId(id);
            if (leilao == null) return NotFound();
            if (leilao.Situacao != SituacaoLeilao.Pregao) return StatusCode(405);
            leilao.Situacao = SituacaoLeilao.Finalizado;
            leilao.Termino = DateTime.Now;
            _daoLeilao.AtualizaLeilao(leilao);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            var leilao = _daoLeilao.BuscarLeilaoPorId(id);
            if (leilao == null) return NotFound();
            if (leilao.Situacao == SituacaoLeilao.Pregao) return StatusCode(405);
            _daoLeilao.RemoverLeilao(leilao);
            return NoContent();
        }

        [HttpGet]
        public IActionResult Pesquisa(string termo)
        {
            ViewData["termo"] = termo;
            var leiloes = _daoLeilao.ListaLeiloesPorTermo(termo);
            return View("Index", leiloes);
        }
    }
}
