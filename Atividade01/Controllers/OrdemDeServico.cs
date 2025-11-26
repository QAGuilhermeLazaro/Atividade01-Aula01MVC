using Microsoft.AspNetCore.Mvc;

namespace Atividade01.Controllers
{
    public class OrdemDeServico : Controller
    {
        public IActionResult Cliente()
        {
            return View();
        }
        public IActionResult Item()
        {
            return View();
        }
    }
}
