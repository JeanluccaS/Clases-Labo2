using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1=0 ;int num2 = 0;
            Console.WriteLine("Calculadora de consola en C# \r");
            Console.WriteLine("-----------------------\n");

            Console.WriteLine("Introduzca el primer numero kpo");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("\ta - sumar");
            Console.WriteLine("\tb - restar");
            Console.WriteLine("\tc - multiplicar");
            Console.WriteLine("\td - dividir");
            Console.WriteLine("tu opcion? ");
            switch(Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"El resultado de: {num1} + {num2} = "+ (num1+num2));
                    break;
                case "b":
                    Console.WriteLine($"El resultado de: {num1} - {num2} = "+ (num1 - num2));
                    break;
                case "c":
                    Console.WriteLine($"El resultado de: {num1} * {num2} = "+ (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"El resultado de: {num1} / {num2} = "+ (num1 / num2));
                    break;

            }
            Console.Write("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
