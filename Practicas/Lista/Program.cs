using System;
using System.Collections.Generic;

namespace sdfsdfsdfs 
{
    class Program {

        static void Main(string[] args) {

            List<string> tacoShoppingList = new List<string>();

            tacoShoppingList.Add("Cinco Tacos de suadero");
            tacoShoppingList.Add("Cuatro Tacos de Tripa");
            tacoShoppingList.Add("Cinco tacos de pastor");
            tacoShoppingList.Add("Cuatro Coca Colas");

            for (int i = 0; i < tacoShoppingList.Count; i++)
            {
                Console.WriteLine(tacoShoppingList[i]);
            }

            Console.WriteLine();

            tacoShoppingList.Remove("Cinco Tacos de suadero");

            for (int i = 0; i < tacoShoppingList.Count; i++)
            {
                Console.WriteLine(tacoShoppingList[i]);
            }

            //tacoShoppingList.RemoveAt(0);
        }
    }
}