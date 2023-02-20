using System;
// Los ciclos FOR ejecutan una instrucci[on o varias, cada vez que ejecuta un ciclo
namespace forCicle
{
    class Program
    {
        static void Main(string[] args)
        {   
            for (int i=0 /*condicion inicial*/; i < 50 /* limite de repeticiones*/; i = i+ 10 /*Incremento*/){
                Console.WriteLine("Hello World! #{0}", i);
            }

            for (int i = 0, j = 0; i < 10 && j > -10; i++, j--){
                Console.WriteLine("i: "+i+" j: "+j);
            }

            // Declaramos e inicializamos nuestra variable
            string[] myComponents = { "Procesador", "Placa Madre", "Fuente de poder", "RAM", "Gabinete", "Monitor" };

            foreach (string component in myComponents)
            {
                Console.WriteLine("Componente: " + component);
			}

            bool continueSoftwareExecution = false;

            do
            {
                Console.WriteLine("Do you wish to keep the software running? write 1 if yes, 0 if no");
                int keepGoing = Convert.ToInt16(Console.ReadLine());
                if (keepGoing == 1)
                {
                    Console.WriteLine("Hello World! The software will keep running");
                    continueSoftwareExecution = true;
                }
                else if (keepGoing == 0)
                {
                    Console.WriteLine("This is the last time the software is running");
                    continueSoftwareExecution = false;
                }
                else
                    Console.WriteLine("Invalid input, Try Again");
            } while (continueSoftwareExecution == true);

        }
    }
}