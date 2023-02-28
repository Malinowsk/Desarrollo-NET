using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb.Models{
    public class Curso:ObjetoEscuelaBase{
        [Required]
        public override string Nombre {get;set;}
        public TiposJornada? Jornada { get; set; }
        public List<Asignatura>? Asignaturas{ get; set; } // Lista de hijos 1:N
        public List<Alumno>? Alumnos{ get; set; } // Lista de ijos 1:N
        public string? Dirección { get; set; }
        public string? EscuelaId {get; set;} // Esta es la FK
        public Escuela? Escuela {get; set;} // Relacion al padre 1:1
    }
}