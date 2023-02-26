using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;
using System.Collections.Generic;

namespace ProyectoWeb.Controllers{
    public class AsignaturaController : Controller{
        public IActionResult Index(){
            return View(new Asignatura{Nombre="Programacion", UniqueId=Guid.NewGuid().ToString()});
        }
        public IActionResult MultiAsignatura(){
            var listaAsignaturas = new List<Asignatura>(){
                new Asignatura{Nombre="Matemáticas", UniqueId=Guid.NewGuid().ToString()} ,
                new Asignatura{Nombre="Educación Física", UniqueId=Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Castellano", UniqueId=Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Ciencias Naturales", UniqueId=Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Programacion", UniqueId=Guid.NewGuid().ToString()}
            };

            ViewBag.CosaDinamica = "La Monja"; // ViewBag es una especie e objeto predefinido en C#
            ViewBag.fecha = DateTime.Now;
            return View("MultiAsignatura",listaAsignaturas); // si no se especifica una vista, se toma por defecto la vista con el nombre de la funcion Index()
        }
    }
} 