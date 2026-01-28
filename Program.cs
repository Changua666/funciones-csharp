using System;

class Program
{
    static void Main(string[] args)
    {
        // INVOCACIONES (LLAMADAS A LAS FUNCIONES)

        Saludar();
        MostrarNumero(10);
        MostrarTexto("Hola C#");
        MostrarSuma(3, 4);

        int r1 = Sumar(5, 6);
        Console.WriteLine(r1);

        string nombre = ObtenerNombre();
        Console.WriteLine(nombre);

        bool mayor = EsMayorDeEdad(20);
        Console.WriteLine(mayor);

        double area = CalcularAreaCuadrado(4.5);
        Console.WriteLine(area);

        int[] numeros = { 1, 2, 3 };
        Console.WriteLine(SumarArreglo(numeros));

        MostrarArreglo(numeros);

        Persona p = new Persona("Juan", 25);
        MostrarPersona(p);

        Console.WriteLine(ObtenerEdadPersona(p));

        CambiarEdad(p, 30);
        MostrarPersona(p);

        Console.WriteLine(Multiplicar(3, 2));

        Console.WriteLine(Concatenar("Hola ", "Mundo"));

        MostrarBooleano(true);

        Console.WriteLine(ObtenerPi());

        ImprimirLinea();

        Console.WriteLine(EsPar(8));

        MostrarCaracter('A');
    }

    // ========= FUNCIONES (FIRMAS) =========

    
    static void Saludar()
    {
        Console.WriteLine("Hola");
    }


    static void MostrarNumero(int numero)
    {
        Console.WriteLine(numero);
    }

    
    static void MostrarTexto(string texto)
    {
        Console.WriteLine(texto);
    }

   
    static void MostrarSuma(int a, int b)
    {
        Console.WriteLine(a + b);
    }

 
    static int Sumar(int a, int b)
    {
        return a + b;
    }

   
    static string ObtenerNombre()
    {
        return "Miguel";
    }

  
    static bool EsMayorDeEdad(int edad)
    {
        return edad >= 18;
    }

  
    static double CalcularAreaCuadrado(double lado)
    {
        return lado * lado;
    }

 
    static int SumarArreglo(int[] numeros)
    {
        int suma = 0;
        foreach (int n in numeros)
        {
            suma += n;
        }
        return suma;
    }

   
    static void MostrarArreglo(int[] numeros)
    {
        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }
    }

    
    static void MostrarPersona(Persona persona)
    {
        Console.WriteLine(persona.Nombre + " - " + persona.Edad);
    }

   
    static int ObtenerEdadPersona(Persona persona)
    {
        return persona.Edad;
    }

    
    static void CambiarEdad(Persona persona, int nuevaEdad)
    {
        persona.Edad = nuevaEdad;
    }

   
    static int Multiplicar(int a, int b)
    {
        return a * b;
    }

   
    static string Concatenar(string a, string b)
    {
        return a + b;
    }

    static void MostrarBooleano(bool valor)
    {
        Console.WriteLine(valor);
    }

    static double ObtenerPi()
    {
        return 3.1416;
    }

   
    static void ImprimirLinea()
    {
        Console.WriteLine("----------------");
    }

    
    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }

   
    static void MostrarCaracter(char c)
    {
        Console.WriteLine(c);
    }
}


class Persona
{
    public string Nombre;
    public int Edad;

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}
