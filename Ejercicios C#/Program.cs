using System;

class Program
{
    static void Main(string[] args)
    {
        decimal lado;

        do
        {
            Console.Write("Ingrese el valor de un lado del cuadrado: ");
            string entrada = Console.ReadLine();

            if (!decimal.TryParse(entrada, out lado))
            {
                Console.WriteLine("\n" + "El valor ingresado no es valido. Intente nuevamente." + "\n");
            }

        } while (lado == 0);

        decimal Perimetro = lado * 4;

        Console.WriteLine("El perímetro del cuadrado es: " + Perimetro);
    }
        
}