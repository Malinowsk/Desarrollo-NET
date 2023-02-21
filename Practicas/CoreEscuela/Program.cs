using System;

namespace CoreEscuela
{   
    class Escuela
    {
        //Atributos por defecto son privados y protegidos
        public string nombre = "";
        public string direccion = "";
        public int añoFundacion;
        public string director = "";

        //Métodos
        public void Timbrar(){
            Console.Beep(987, 1000); //Si
            Console.Beep(1174, 500); //Re'
            Console.Beep(880, 1500); //La

            Console.Beep(783, 250); //Sol
            Console.Beep(880, 250); //La
            Console.Beep(987, 1000); //Si

            Console.Beep(1174, 500); //Re'
            Console.Beep(880, 1500); //La

            Console.Beep(987, 1000); //Si
            Console.Beep(1174, 500); //Re'
            Console.Beep(1760, 1000); //La'
            Console.Beep(1567, 500); //Sol'
            Console.Beep(1174, 1000); //Re'

            Console.Beep(1046, 250); //Do
            Console.Beep(987, 250); //Si
            Console.Beep(880, 1000); //La

            //Console.Beep(523, 500); //Do
           
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "Carlos Hank González";
            miEscuela.direccion = "Valentin Gomez Faríaz #211";
            miEscuela.añoFundacion = 1980;

            Console.WriteLine("Timbrando");
            miEscuela.Timbrar();
        }
    }
}