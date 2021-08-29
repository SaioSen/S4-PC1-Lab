using Microsoft.AspNetCore.Mvc;
using S4_PC1_Lab.Models;
using S4_PC1_Lab.Data;
using System.Linq;

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
            return View(_context.DataProductos.ToList());
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
            return View();
        }

        public IActionResult Edit(int id)
        {
            Producto objProducto = _context.DataProductos.Find(id);
            if(objProducto == null){
                return NotFound();
            }
            return View(objProducto);
        }

        [HttpPost]
        public IActionResult Edit(int id,[Bind("Id,Nombre,Categoria,Precio,Descuento")] Producto objProducto)
        {
             _context.Update(objProducto);
             _context.SaveChanges();
              ViewData["Message"] = "El producto ya esta actualizado";
             return View(objProducto);
        }

        public IActionResult Delete(int id)
        {
            Producto objProducto = _context.DataProductos.Find(id);
            _context.DataProductos.Remove(objProducto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


    }
}