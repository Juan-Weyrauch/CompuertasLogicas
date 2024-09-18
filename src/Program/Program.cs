// See https://aka.ms/new-console-template for more information
using System;
using DefaultNamespace;
using Library;

public class Program
{
    public static void Main(string[] args)
    {
        var and = new And();
        var or = new Or();
        var not = new Not();
        Console.WriteLine(and.Funcion([false, true]));
        Console.WriteLine(or.Funcion([false, true]));
        Console.WriteLine(not.Funcion([false]));
        
       /* var and1 = new And();
        bool answer = and1.Funcion([true, true]);
        
        Console.WriteLine(and.Funcion([answer, true])); */
        
       
       //Primer and: 
       And a = new And();
       And b = new And();
       And c = new And();
       
       
       
       
       
    }
}