using System;

namespace ProyectoWeb.Models
{
    public class Evaluación:ObjetoEscuelaBase
    {
        public Alumno Alumno { get; set; } // Relacion al padre 1:1
        public string AlumnoId{get;set;} // Esta es la FK
        public Asignatura Asignatura  { get; set; } // Relacion al padre 1:1
        public string AsignaturaId{get;set;} // Esta es la FK

        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}