using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public string file_name = $"{file_name1}";
    static string file_name1;

    public string return_file()
    {
        return file_name;
    }
    
    public void Write()
    {
        Prompts prompt = new Prompts();
        prompt.NewQuestion();
        
    }

    public void display()
    {
        string file = file_name;
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            Console.WriteLine($"{line}");
        }
    }
    public string load()
    {
        
        Console.WriteLine("What file do you want to load? ");
        file_name1 = Console.ReadLine();

        return file_name1;
        
    }

    public void load_file()
    {
        Journal file = new Journal();
        file.load();


        string[] lines = System.IO.File.ReadAllLines(file_name);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            Console.WriteLine($"{line}");
        }

    }

}













