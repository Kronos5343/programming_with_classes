using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    List<Entries> listOfEntries = new List<Entries>();
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
        foreach (var part in listOfEntries)
        {
           Console.WriteLine(part); 
        }
    }
    public void load()
    {
        Entries loadEntries = new Entries();
        Console.WriteLine("What file do you want to load? ");
        file_name1 = Console.ReadLine();
        loadEntries.ConstructEntries(file_name);
    }

}













