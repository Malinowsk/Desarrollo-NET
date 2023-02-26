using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ProyectoWeb.Models;
using System.Collections.Generic;

namespace ProyectoWeb.Controllers{
    public class AsignaturaController : Controller{
        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context){
            _context = context;
        }
        public IActionResult Index(string id){
            if(!string.IsNullOrWhiteSpace(id)){
                var asignatura = from asig in _context.Asignaturas
                                where asig.Id == id
                                select asig;
                return View(asignatura.SingleOrDefault());
            }
            else{
                return View("MultiAsignatura",_context.Asignaturas); // si no se especifica una vista, se toma por defecto la vista con el nombre de la funcion Index()    
            } 
        }
        public IActionResult MultiAsignatura(){
            ViewBag.CosaDinamica = "La Monja"; // ViewBag es una especie e objeto predefinido en C#
            ViewBag.fecha = DateTime.Now;
            return View("MultiAsignatura",_context.Asignaturas); // si no se especifica una vista, se toma por defecto la vista con el nombre de la funcion Index()
        }
    }
} 