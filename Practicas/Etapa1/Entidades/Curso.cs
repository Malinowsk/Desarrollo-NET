using System;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        
        public Curso(string nombre = "" ){
            UniqueId = Guid.NewGuid().ToString();
            this.Nombre = nombre;
        } 
    }
}