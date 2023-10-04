using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    
    // public string file_to_load()
    // {
    //     Console.WriteLine("What file do you want to load? ");
    //     string load_file = Console.ReadLine();
    //     return load_file;

    // }

    public void Write()
    {
        Prompts prompt = new Prompts();
        prompt.NewQuestion();

    }
    public void display()
    {
        string file = "Records.txt";
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            Console.WriteLine($"{line}");
        }
    }
    public void load()
    {
        Console.WriteLine("What file do you want to load? ");
        string load_file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(load_file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            Console.WriteLine($"{line}");
        }
        
    }

}













