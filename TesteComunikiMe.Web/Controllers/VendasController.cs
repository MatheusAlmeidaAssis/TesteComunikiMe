using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Web.Repositories;

namespace TesteComunikiMe.Web.Controllers
{
    public class VendasController : Controller
    {
        private readonly VendaRepository _vendaRepository;
        private readonly ClienteRepository _clienteRepository;
        private readonly ProdutoRepository _produtoRepository;

        public VendasController()
        {
            _vendaRepository = new VendaRepository();
            _clienteRepository = new ClienteRepository();
            _produtoRepository = new ProdutoRepository();
        }

        // GET: VendasController
        public async Task<ActionResult> Index()
        {
            var vendas = await _vendaRepository.Get();

            return View(vendas);
        }

        // GET: VendasController/Details/5
        public async Task<IActionResult> Consultar(int id)
        {
            var venda = await _vendaRepository.Get(id);

            return View(venda);
        }

        // GET: VendasController/Create
        public async Task<IActionResult> Adicionar()
        {
            var venda = new VendaDto();

            await FillViewBag();

            return View(venda);
        }

        private async Task FillViewBag()
        {
            ViewBag.Clientes = await _clienteRepository.Get();
            ViewBag.Produtos = await _produtoRepository.Get();
        }

        // POST: VendasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Adicionar(VendaDto vendaDto)
        {
            if (ModelState.IsValid)
            {
                await _vendaRepository.Add(vendaDto);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                FillViewBag();
                return View(vendaDto);
            }
        }

        // GET: VendasController/Edit/5
        public async Task<IActionResult> Editar(int id)
        {
            var venda = await _vendaRepository.Get(id);

            FillViewBag();

            return View(venda);
        }

        // POST: VendasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(VendaDto vendaDto)
        {
            if (ModelState.IsValid)
            {
                await _vendaRepository.Update(vendaDto);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                FillViewBag();
                return View(vendaDto);
            }
        }

        // GET: VendasController/Delete/5
        public async Task<IActionResult> Excluir(int id)
        {
            await _vendaRepository.Remove(id);

            return RedirectToAction(nameof(Index));
        }
    }
}