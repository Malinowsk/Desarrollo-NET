using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers{
    public class EscuelaController : Controller{
        public IActionResult Index(){
            var escuela = new Escuela();
            escuela.AñoDeCreación=2005;
            escuela.UniqueId=Guid.NewGuid().ToString();
            escuela.Nombre="Escuela N°1";
            escuela.Ciudad="wadalajara";
            escuela.Pais="Mongolia";
            escuela.TipoEscuela=TiposEscuela.Secundaria;
            escuela.Dirección="Callefalsa 123";

            ViewBag.CosaDinamica = "La Monja"; // ViewBag es una especie e objeto predefinido en C#
            return View(escuela); // si no se especifica una vista, se toma por defecto la vista con el nombre de la funcion Index()
        }
    }
}