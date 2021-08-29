using Microsoft.AspNetCore.Mvc;
using S4_PC1_Lab.Models;
namespace S4_PC1_Lab.Controllers
{
    public class ProductoController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]  
        public IActionResult Create(Producto objProducto)
        {
            ViewData["Message"] = "Producto Registrado";
            return View("Index");
        }


    }
}