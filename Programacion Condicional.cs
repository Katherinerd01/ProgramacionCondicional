using System;

public class Program
{
    public static void Main()
    {

        int num1, num2;

        Console.Write($"Ingrese el primer numero:");
        num1 = Convert.ToInt32(Console.ReadLine());



        Console.Write($"Ingrese el segundo numero:");
        num2 = Convert.ToInt32(Console.ReadLine());


        if (num1 > num2)

        {
            int suma = num1 + num2;


            int resta = num1 - num2;
            Console.Write($"La suma de los dos numeros es:");
            Console.WriteLine(suma);
            Console.Write($"La diferencia de los numeros es:");
            Console.WriteLine(resta);
        }
        else
        {
           
            int producto = num1 * num2;
            int division = num1 / num2;
            Console.Write($"El producto de los numeros es:");
            Console.WriteLine(producto);
            Console.Write($"La division de los dos numeros es:");
            Console.WriteLine(division);

        }
    }
}

