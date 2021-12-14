using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Web.Repositories;

namespace TesteComunikiMe.Web.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ClienteRepository _clienteRepository;

        public ClientesController()
        {
            _clienteRepository = new ClienteRepository();
        }

        // GET: ClienteController
        public async Task<IActionResult> Index()
        {
            var clientes = await _clienteRepository.Get();

            return View(clientes);
        }

        // GET: ClienteController/Details/5
        public async Task<IActionResult> Consultar(int id)
        {
            var cliente = await _clienteRepository.Get(id);

            return View(cliente);
        }

        // GET: ClienteController/Create
        public IActionResult Adicionar()
        {
            var cliente = new ClienteDto();

            return View(cliente);
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Adicionar(ClienteDto clienteDto)
        {
            if (ModelState.IsValid)
            {
                await _clienteRepository.Add(clienteDto);
                return RedirectToAction(nameof(Index));
            }
            else
                return View(clienteDto);
        }

        // GET: ClienteController/Edit/5
        public async Task<IActionResult> Editar(int id)
        {
            var cliente = await _clienteRepository.Get(id);

            return View(cliente);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(ClienteDto clienteDto)
        {
            if (ModelState.IsValid)
            {
                await _clienteRepository.Update(clienteDto);
                return RedirectToAction(nameof(Index));
            }
            else
                return View(clienteDto);
        }

        // GET: ClienteController/Delete/5
        public async Task<IActionResult> Excluir(int id)
        {
            await _clienteRepository.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}