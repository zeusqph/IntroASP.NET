using IntroASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroASP.NET.Controllers
{
    // Controlador encargado de mostrar las cervezas.
    public class BeerController : Controller
    {

        // Contexto de la base de datos.
        private readonly PubContext _context;

        // Constructor que recibe el contexto mediante inyección de dependencias.
        public BeerController(PubContext context)
        {
            _context = context;
        }

        // Muestra la lista de cervezas junto con su marca.
        public async Task<IActionResult> Index()
        {
            // Obtiene las cervezas e incluye la información de la marca.
            var beers = _context.Beers.Include(b => b.Brand);
            // Envía la lista a la vista.
            return View(await beers.ToListAsync());
        }

    }
}
