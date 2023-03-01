using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ProyectoWeb.Models;
using System.Collections.Generic;

namespace ProyectoWeb.Controllers{
    public class CursoController : Controller{
        private EscuelaContext _context;
        public CursoController(EscuelaContext context){
            _context = context;
        }
        public IActionResult Index(string id){
            if(!string.IsNullOrWhiteSpace(id)){
                var curso = from curs in _context.Cursos
                                where curs.Id == id
                                select curs;
                return View(curso.SingleOrDefault());
            }
            else{
                return View("MultiCurso",_context.Cursos); // si no se especifica una vista, se toma por defecto la vista con el nombre de la funcion Index()    
            } 
        }
        public IActionResult Create(){
            ViewBag.fecha = DateTime.Now;
            
            return View(); // si no se especifica una vista, se toma por defecto la vista con el nombre de la funcion Index()
        }

        [HttpPost]
        public IActionResult Create(Curso curso){
            curso.Id=Guid.NewGuid().ToString();
            ViewBag.fecha = DateTime.Now;
            if(ModelState.IsValid){
                var escuela = _context.Escuelas.FirstOrDefault();
                curso.EscuelaId = escuela.Id;
                _context.Cursos.Add(curso);
                _context.SaveChanges();
                ViewBag.MensajeExtra ="Curso Creado";
                return View("Index", curso); // si no se especifica una vista, se toma por defecto la vista con el nombre de la funcion Index()
            }
            else{
                return View(curso); // si no se especifica una vista, se toma por defecto la vista con el nombre de la funcion Index()
            }
        }

        public IActionResult MultiCurso(){
            ViewBag.CosaDinamica = "La Monja"; // ViewBag es una especie e objeto predefinido en C#
            ViewBag.fecha = DateTime.Now;
            return View("MultiCurso",_context.Cursos); // si no se especifica una vista, se toma por defecto la vista con el nombre de la funcion Index()
        }
    }
} 