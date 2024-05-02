using System;

  class Program
{
    static void Main(string[] args)

    { 
        int Nota1, Nota2, Nota3; 
        Console.Write("Ingrese primer nota:"); 
        Nota1 = int.Parse(Console.ReadLine()); 
        Console.Write("Ingrese segunda nota:"); 
        Nota2 = int.Parse(Console.ReadLine()); 
        Console.Write("Ingrese tercer nota:"); 
        Nota3 = int.Parse(Console.ReadLine()); 
        
        int Promedio = (Nota1 + Nota2 + Nota3) / 3; 

        if (Promedio >= 7) 
        { 
            Console.Write("Promocionado"); 
        } 
        else 
        { 
            if (Promedio >= 4 && Promedio <7) 

            { Console.Write("Regular"); 

            } 
            else 
            { 
                Console.Write("Reprobado"); 
            } 
        }
        Console.ReadKey(); 
    }
}




