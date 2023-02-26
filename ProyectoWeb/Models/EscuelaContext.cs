using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoWeb.Models{
    public class EscuelaContext: DbContext{
        public DbSet<Escuela> Escuelas {get; set;}
        public DbSet<Asignatura> Asignaturas {get; set;}
        public DbSet<Alumno> Alumnos {get; set;}
        public DbSet<Curso> Cursos {get; set;}
        public DbSet<Evaluación> Evaluaciones {get; set;}

        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options){
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            var escuela = new Escuela();
            escuela.AñoDeCreación=2005;
            escuela.Id=Guid.NewGuid().ToString();
            escuela.Nombre="Escuela N°1";
            escuela.Ciudad="wadalajara";
            escuela.Pais="Mongolia";
            escuela.TipoEscuela=TiposEscuela.Secundaria;
            escuela.Dirección="Callefalsa 123";
            //Cargar Cursos de la escuela
            var cursos = CargarCursos(escuela);
            //x cada curso cargar asignaturas
            var asignaturas = CargarAsignaturas(cursos);            
            //x cada curso cargar alumnos
            var alumnos = CargarAlumnos(cursos);
            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray()); // Funcion que agrega los datos cuando no tiene datos

        }
            
        private List<Alumno> GenerarAlumnosAlAzar(Curso curso, int cantidad){
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno {
                                    CursoId = curso.Id,
                                    Nombre = $"{n1} {n2} {a1}",
                                    Id = Guid.NewGuid().ToString() 
                                };

            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos){
            var listaCompleta = new List<Asignatura>();
            foreach(var Curso in cursos){
                var tmplist = new List<Asignatura> {
                    new Asignatura{Id=Guid.NewGuid().ToString(), CursoId = Curso.Id, Nombre="Matematicas"} ,
                    new Asignatura{Id=Guid.NewGuid().ToString(), CursoId = Curso.Id, Nombre="Educacion Fisica"},
                    new Asignatura{Id=Guid.NewGuid().ToString(), CursoId = Curso.Id, Nombre="Castellano"},
                    new Asignatura{Id=Guid.NewGuid().ToString(), CursoId = Curso.Id, Nombre="Ciencias Naturales"},
                    new Asignatura{Id=Guid.NewGuid().ToString(), CursoId = Curso.Id, Nombre="Programacion"}
                };
                listaCompleta.AddRange(tmplist);
                //Curso.Asignaturas = tmplist;
            }
            return listaCompleta;
        }

        private static List<Curso> CargarCursos(Escuela escuela){
            return new List<Curso>(){
                new Curso() {Id = Guid.NewGuid().ToString(), Dirección = "Callefalsa 123", EscuelaId = escuela.Id, Nombre = "101", Jornada = TiposJornada.Mañana} ,
                new Curso() {Id = Guid.NewGuid().ToString(), Dirección = "Callefalsa 124", EscuelaId = escuela.Id, Nombre = "102", Jornada = TiposJornada.Tarde},
                new Curso() {Id = Guid.NewGuid().ToString(), Dirección = "Callefalsa 125", EscuelaId = escuela.Id, Nombre = "103", Jornada = TiposJornada.Noche},
                new Curso() {Id = Guid.NewGuid().ToString(), Dirección = "Callefalsa 126", EscuelaId = escuela.Id, Nombre = "104", Jornada = TiposJornada.Mañana},
                new Curso() {Id = Guid.NewGuid().ToString(), Dirección = "Callefalsa 127", EscuelaId = escuela.Id, Nombre = "105", Jornada = TiposJornada.Tarde}
            };
        }

        private List<Alumno> CargarAlumnos(List<Curso> cursos){
            var listaAlumnos = new List<Alumno>();
            Random rnd = new Random();
            foreach (var curso in cursos){
                int cantRandom = rnd.Next(5, 20);
                var tmplist = GenerarAlumnosAlAzar(curso, cantRandom);
                listaAlumnos.AddRange(tmplist);
            }
            return listaAlumnos;
        }
    }
}