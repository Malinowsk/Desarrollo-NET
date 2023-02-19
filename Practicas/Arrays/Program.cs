using System;

namespace acavacualquiercosa

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tiposDeCafe;
            float[] valorDeCafe;

            tiposDeCafe = new string[] { "Simple", "Cortado" , "Expresso" };
            valorDeCafe = new float[] { 2.0f , 10.5f , 25.5f };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine( "Cafe: " + tiposDeCafe[i] + " , Valor : $ " + valorDeCafe[i]);
            }
        }
    }
}
