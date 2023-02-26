using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ProyectoWeb.Models;
using System.Collections.Generic;

namespace ProyectoWeb.Controllers{
    public class AlumnoController : Controller{
        public IActionResult Index(){
            return View(new Alumno{Nombre="PEPE", UniqueId=Guid.NewGuid().ToString()});
        }
        public IActionResult MultiAlumno(){
            var listaAlumnos = GenerarAlumnosAlAzar();
            ViewBag.CosaDinamica = "La Monja"; // ViewBag es una especie e objeto predefinido en C#
            ViewBag.fecha = DateTime.Now;
            return View("MultiAlumno",listaAlumnos); // si no se especifica una vista, se toma por defecto la vista con el nombre de la funcion Index()
        }
        private List<Alumno> GenerarAlumnosAlAzar(){
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}", 
                                                   UniqueId = Guid.NewGuid().ToString() 
                                                };

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }
    }
} 