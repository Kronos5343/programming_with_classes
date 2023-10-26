using System;

class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizer!");
        
        Reference reference = new Reference("James", "1:", "5");
        Scripture scripture = new Scripture(reference, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.");
        
        scripture.Display();
    }
}