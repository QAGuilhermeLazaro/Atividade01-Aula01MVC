using Microsoft.AspNetCore.Mvc;

namespace Atividade01.Controllers
{
    public class Estoque : Controller
    {
        public IActionResult Produtos()
        {
            return View();
        }
        public IActionResult Servicos()
        {
            return View();
        }

    }
}
