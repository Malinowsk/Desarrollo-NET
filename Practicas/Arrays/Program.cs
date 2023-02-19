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
            valorDeCafe = new float[] { 4.0f , 10.5f , 25.5f };

            for (int i = 0; i < tiposDeCafe.Length; i++)
            {

                Console.WriteLine( "Cafe: " + tiposDeCafe[i] + " , Valor : $ " + valorDeCafe[i]);
                
                // Otra forma mas moderna que se agrego con la feature C# 6
                //Console.WriteLine($"Cafe: {tiposDeCafe[i]}  , Valor : $  {valorDeCafe[i]}");
            }
        }
    }
}
