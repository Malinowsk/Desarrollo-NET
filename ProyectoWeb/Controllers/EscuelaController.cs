using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers{
    public class EscuelaController : Controller{

        public IActionResult Index(){

            ViewBag.CosaDinamica = "La Monja"; // ViewBag es una especie e objeto predefinido en C#
            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela); // si no se especifica una vista, se toma por defecto la vista con el nombre de la funcion Index()
        }
        private EscuelaContext _context;
        public EscuelaController(EscuelaContext context){
            _context = context;
        }
    }
}