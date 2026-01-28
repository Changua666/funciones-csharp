using System;

class Program
{
    static void Main()
    {
        int opcion = 0;

        while (opcion != -1)
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1. División");
            Console.WriteLine("2. Módulo");
            Console.WriteLine("3. Cuadrado");
            Console.WriteLine("-1. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }

            if (opcion == -1)
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }

            if (opcion == 1)
            {
                Console.Write("Ingrese el dividendo: ");
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("Dato inválido.");
                    continue;
                }

                Console.Write("Ingrese el divisor: ");
                if (!double.TryParse(Console.ReadLine(), out double b) || b == 0)
                {
                    Console.WriteLine("Divisor inválido o cero.");
                    continue;
                }

                Console.WriteLine("Resultado: " + (a / b));
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese el primer número: ");
                if (!int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("Dato inválido.");
                    continue;
                }

                Console.Write("Ingrese el segundo número: ");
                if (!int.TryParse(Console.ReadLine(), out int b) || b == 0)
                {
                    Console.WriteLine("Dato inválido o cero.");
                    continue;
                }

                Console.WriteLine("Resultado: " + (a % b));
            }
            else if (opcion == 3)
            {
                Console.Write("Ingrese un número: ");
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("Dato inválido.");
                    continue;
                }

                Console.WriteLine("Resultado: " + (a * a));
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }
}
