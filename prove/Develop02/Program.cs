using System;

class Program
{
    static void Main(string[] args)
    {
        Journal load = new Journal();
        load.load();
        Console.WriteLine("Welcome to your new Journal :)");

        menu_system menu = new menu_system();
    
        menu.Display();








    }















}