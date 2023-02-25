namespace Despacho.Comida{
    class Comida{
        private string Nombre {get; set;}
        private string Tipo {get; set;}
        private string ModoPreparacion {get; set;}
        private bool Aceptar {get; set;}

        public Comida(string nombre, string tipo, string modoPreparacion, bool aceptar) => (Nombre, Tipo, ModoPreparacion, Aceptar) = (nombre, tipo, modoPreparacion, aceptar);

    }
}

namespace CoreEscuela.Entidades
{
    class Escuela{

        string nombre = "Anonimo";

        public string Nombre
        {
            get{ return nombre; }   // getter de nombre
            set{ nombre = value; }  // setter de nombre
        }

        public int AñoDeCreación { get; set; } // equivale a propiedad , geter y seter de la misma

        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public Curso[] Cursos { get; set; }
        //public Escuela(string nombre, int año) => (Nombre, AñoDeCreación) = (nombre, año);

        public Escuela(string nombre, int año,  TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            (Nombre, AñoDeCreación) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
            Cursos = new Curso[]{};
        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad:{Ciudad}";
        }
    }

}