// See https://aka.ms/new-console-template for more information
using System;
using Library;

public class Program
{
    public static void Main(string[] args)
    {
        /*var and = new And();
        var or = new Or();
        var not = new Not();
        Console.WriteLine(and.Funcion([false, true]));
        Console.WriteLine(or.Funcion([false, true]));
        Console.WriteLine(not.Funcion([false]));
        */
        
        GarageGate compuerta = new GarageGate();
        Console.WriteLine(compuerta.Funcion([true,false,false]));
        // El [0] de la lista es el a, el [1] es el b, [2] es el c.
    }
}