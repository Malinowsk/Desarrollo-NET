using System;

namespace ProyectoWeb.Models{
    public class Asignatura:ObjetoEscuelaBase{
        public string CursoId{get;set;} // Esta es la FK
        public Curso Curso{get;set;} // Relacion al padre 1:1
        public List<Evaluación> Evaluaciones { get; set; } // Lista de hijos 1:N

    }
}