using Microsoft.AspNetCore.Mvc;
using S4_PC1_Lab.Models;
using S4_PC1_Lab.Data;

namespace S4_PC1_Lab.Controllers
{
    public class ProductoController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }


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
            _context.Add(objProducto);
            _context.SaveChanges();
            ViewData["Message"] = "Producto Registrado";
            return View("Index");
        }


    }
}