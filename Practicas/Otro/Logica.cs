using System;

namespace Otro
{
    class Logica {
        Console.WriteLine("Hello World!");

        bool value1 = true;
        bool value2 = true;
        bool value3 = false;

        // && , ||, !

        bool result = value1 && value2 && value3;
        Console.WriteLine("The result of the logical AND is: " + result);

        bool result2 = value1 || value2 || value3;
        Console.WriteLine("The result of the logical OR is: " + result2);

        bool result3 = !value1;
        Console.WriteLine("The result of the logical ! is: " + result3);
    }
}