using System;

namespace Otro
{

    class Area
        {
            static void Main(string[] args)
            {
                //rectangle area calc.

                //rectangle values
                float sideA = 10.0f;
                int sideB = 1;
                sideB++;
                sideB++;
                sideB++;
                sideB--;
                //rectangle area formula is a*b
                float area = sideA * sideB;


                Console.WriteLine("The rectangle area: " + area);
                Console.ReadLine();

            }
        }
}