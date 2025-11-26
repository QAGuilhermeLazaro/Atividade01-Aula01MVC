using Microsoft.AspNetCore.Mvc;

namespace Atividade01.Controllers
{
    public class Funcionario : Controller
    {
        public IActionResult Cargo()
        {
            return View();
        }
        public IActionResult Horas()
        {
            return View();
        }
    }
}
