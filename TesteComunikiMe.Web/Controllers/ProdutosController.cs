using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Web.Repositories;

namespace TesteComunikiMe.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutoRepository _produtoRepository;

        public ProdutosController()
        {
            _produtoRepository = new ProdutoRepository();
        }

        // GET: ProdutosController
        public async Task<ActionResult> Index()
        {
            var produtos = await _produtoRepository.Get();

            return View(produtos);
        }

        // GET: ProdutosController/Details/5
        public async Task<IActionResult> Consultar(int id)
        {
            var produto = await _produtoRepository.Get(id);

            return View(produto);
        }

        // GET: ProdutosController/Create
        public IActionResult Adicionar()
        {
            var produto = new ProdutoDto();

            return View(produto);
        }

        // POST: ProdutosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Adicionar(ProdutoDto produtoDto)
        {
            if (ModelState.IsValid)
            {
                await _produtoRepository.Add(produtoDto);
                return RedirectToAction(nameof(Index));
            }
            else
                return View(produtoDto);
        }

        // GET: ProdutosController/Edit/5
        public async Task<IActionResult> Editar(int id)
        {
            var produto = await _produtoRepository.Get(id);

            return View(produto);
        }

        // POST: ProdutosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(ProdutoDto produtoDto)
        {
            if (ModelState.IsValid)
            {
                await _produtoRepository.Update(produtoDto);
                return RedirectToAction(nameof(Index));
            }
            else
                return View(produtoDto);
        }

        // GET: ProdutosController/Delete/5
        public async Task<IActionResult> Excluir(int id)
        {
            await _produtoRepository.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}