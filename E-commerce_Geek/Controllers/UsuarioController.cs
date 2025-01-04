using Microsoft.AspNetCore.Mvc;

namespace E_commerce_Geek.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            return View();
        }
    }
}
