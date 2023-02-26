using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ProyectoWeb.Models;
using System.Collections.Generic;

namespace ProyectoWeb.Controllers{
    public class AlumnoController : Controller{
        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context){
            _context = context;
        }
        public IActionResult Index(string id){
            if(!string.IsNullOrWhiteSpace(id)){
                var alumno = from alumn in _context.Alumnos
                                where alumn.Id == id
                                select alumn;
                return View(alumno.SingleOrDefault());
            }
            else{
                return View("MultiAlumno",_context.Alumnos); // si no se especifica una vista, se toma por defecto la vista con el nombre de la funcion Index()    
            } 
        }
        public IActionResult MultiAlumno(){
            ViewBag.CosaDinamica = "La Monja"; // ViewBag es una especie e objeto predefinido en C#
            ViewBag.fecha = DateTime.Now;
            return View("MultiAlumno",_context.Alumnos); // si no se especifica una vista, se toma por defecto la vista con el nombre de la funcion Index()
        }
    }
} 