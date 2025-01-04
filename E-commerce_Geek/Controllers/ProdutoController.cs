using Microsoft.AspNetCore.Mvc;

namespace E_commerce_Geek.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Produto()
        {
            return View();
        }

        public IActionResult Favoritos()
        {
            return View();
        }
    }
}
