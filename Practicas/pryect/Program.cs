using System;

/*
 * 1. Validar si es usuario existente o si se debe registrar, y generar un sistema de registro o login
 * 2. el programa debe ser capaz de darle la bienvenida a un usuario existente si en efecto existe
 * 3. el programa debe repetirse hasta que se registren las 10 personas
 */
namespace restaurant10TablesReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Colque El usuario y Contrraseña");

            Console.WriteLine("La contraseña es Los primeros numeros y El usuario de xbox");
            Console.WriteLine("el usuario es la empresa de steam");
            Console.WriteLine("usario");
            string Username = Console.ReadLine();
            Console.WriteLine("password");
            string password = Console.ReadLine();
            //preguntas
            string exercise1 = "1)La masa atómica media relativa de los elementos no tiene un número entero, ¿esto se debe a que?:";
            string exercise2 = "2)Sea la reacción en equilibrio, entre gases, 2 A ⇋ B + C. Ante una disminución de la presión a temperatura constante, el equilibrio se desplazará:";
            string exercise3 = "3)Cuál es la capital de Hungría?";
            string exercise4 = "4)Aproximadamente, ¿cuántos huesos tiene el cuerpo humano?";
            string exercise5 = "5)En el mesencéfalo se ubican:";
            string exercise6 = "6)Indique con cuántos puntos califica una película perfecta"; 
            string exercise7 = "7)Las empresas públicas:";
            string exercise8 = "8)Cuando una empresa tiene varios propietarios recibe el nombre de:";
            string exercise9 = "9)Las empresas con localización internacional se denominan:";
            //respuestas
            string[] option1 = new string[4] {"A.Los átomos del elemento tienen distinto número de protones", "B.Los átomos del elemento tienen distinto número de electrones", "C.Hay impurezas de otros elementos", "D.Los átomos del elemento difieren en el número de neutrones"};
            string[] option2 = new string[4] {"A.Hacia la derech", "B.No se produce desplazamiento", "C.Hacia la izquierda", "D.Depende de la temperatura"};
            string[] option3 = new string[4] {"A.Viena", "B.Praga", "C.Budapest", "D.Estambul" };
            string[] option4 = new string[3] {"A.40", "B.390", "C.208"};
            string[] option5 = new string[4] {"A.Colículos superiores e inferiores", "B.El cuarto ventrículo", "C.Deriva de la vesícula terciaria", "D.Las pirámides bulbares"};
            string[] option6 = new string[10] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
            string[] option7 = new string[3] {"A.Son aquellas que ofrecen servicios gratuitos.", "B.Son aquellas cuyo capital y control pertenece al Estado, Comunidades Autónomas o ayuntamientos.", "C.Son aquellas que ya se han privatizado."};
            string[] option8 = new string[3] {"A.Sociedad.", "B.Multinacional.", "C.Empresa privada."};
            string[] option9 = new string[3] { "A.Multinacionales.", "B.Holding.", "C.Cartel."};

            if (Username == "Valde" && password == "12345Clon54")
            {
                while(Username == "Valde" && password == "12345Clon54")
                {
                    Console.WriteLine("examen sobresa");
                    Console.WriteLine("Son 9 preguntas que debes reponder");
                    Console.WriteLine(exercise1);
                    Console.WriteLine($"{option1[0]}  {option1[1]} {option1[2]} {option1[3]}");
                    Console.WriteLine("respusta:");
                    string response1 = Console.ReadLine();
                    Console.WriteLine(exercise2);
                    Console.WriteLine($"{option2[0]}  {option2[1]} {option2[2]} {option2[3]}");
                    Console.WriteLine("respusta:");
                    string response2 = Console.ReadLine();
                    Console.WriteLine(exercise3);
                    Console.WriteLine($"{option3[0]}  {option3[1]} {option3[2]} {option3[3]}");
                    Console.WriteLine("respusta:");
                    string response3 = Console.ReadLine();
                    Console.WriteLine(exercise4);
                    Console.WriteLine($"{option4[0]}  {option4[1]} {option4[2]}");
                    Console.WriteLine("respusta:");
                    string response4 = Console.ReadLine();
                    Console.WriteLine(exercise5);
                    Console.WriteLine($"{option5[0]}  {option5[1]} {option5[2]} {option5[3]}");
                    Console.WriteLine("respusta:");
                    string response5 = Console.ReadLine();
                    Console.WriteLine(exercise6+" coloca un nuemro");
                    Console.WriteLine($"{option6[0]}  {option6[1]} {option6[2]} {option6[3]} {option6[4]} {option6[5]} {option6[6]} {option6[7]} {option6[8]} {option6[9]}");
                    Console.WriteLine("respusta:");
                    string response6 = Console.ReadLine();
                    Console.WriteLine(exercise7);
                    Console.WriteLine($"{option7[0]}  {option7[1]} {option7[2]}");
                    Console.WriteLine("respusta:");
                    string response7 = Console.ReadLine();
                    Console.WriteLine(exercise8);
                    Console.WriteLine($"{option8[0]}  {option8[1]} {option8[2]}");
                    Console.WriteLine("respusta:");
                    string response8 = Console.ReadLine();
                    Console.WriteLine(exercise9);
                    Console.WriteLine($"{option9[0]}  {option9[1]} {option9[2]}");
                    Console.WriteLine("respusta:");
                    string response9 = Console.ReadLine();
                    //logica del programa
                    if(response1 == "d" | response1 == "D")
                    {
                        Console.WriteLine("correcto");
                    }
                    else
                    {
                        Console.WriteLine("incorrecta");
                    }
                    if(response2 == "b" | response2 == "B")
                    {
                        Console.WriteLine("correcto");
                    }
                    else
                    {
                        Console.WriteLine("incorrecta");
                    }
                    if(response3 == "c" | response3 == "C")
                    {
                        Console.WriteLine("correcto");
                    }
                    else
                    {
                        Console.WriteLine("incorrecta");
                    }
                    if(response4 == "c" | response4 == "C")
                    {
                        Console.WriteLine("correcto");
                    }
                    else
                    {
                        Console.WriteLine("incorrecta");
                    } 
                    if(response5 == "a" | response5 == "A")
                    {
                        Console.WriteLine("correcto");
                    }
                    else
                    {
                        Console.WriteLine("incorrecta");
                    }
                    if(response6 == "10" | response6 == "10")
                    {
                        Console.WriteLine("correcto");
                    }
                    if (response7 == "b" | response7 == "B")
                    {
                        Console.WriteLine("correcto");
                    }
                    if (response8 == "a" | response8 == "A")
                    {
                        Console.WriteLine("correcto");
                    }
                    else
                    {
                        Console.WriteLine("incorrecto");
                    }
                    if(response9 == "a" | response9 == "A")
                    {
                        Console.WriteLine("correcto");
                    }
                    else
                    {
                        Console.WriteLine("correcto");
                        
                    }

                    if (response1 == "d" | response1 == "D" && response2 == "b" | response2 == "B" && response3 == "c" | response3 == "C" && response4 == "c" | response4 == "C" && response5 == "a" | response5 == "A" && response6 == "10" | response6 == "10" && response7 == "b" | response7 == "B" && response8 == "a" | response8 == "A" && response9 == "a" | response9 == "A")
                    {
                        Console.WriteLine("felicidades tuviste 9/9");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine($"tuviste una opcion mala por favor repita el examen\n");
                    }
                
                
                }
            }
            else
            {
                if (Username != "Valde")
                {
                    Console.WriteLine(" pista donde intalas Stumble en PC");

                }
                if (password != "12345Clon54")
                {
                    Console.WriteLine("pista" + 12345 + "Clon54");
                }
                Console.WriteLine("usuario y/o contraseña incorretas");
            }

        }
    }
}