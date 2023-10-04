using System;
using System.Formats.Asn1;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


public class Prompts
{

    static string[] questions = new string[] 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };



    static Random randomGenerator = new Random();
    int number = randomGenerator.Next(questions.Length);

    public void NewQuestion()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();


        Console.WriteLine(questions[number]);
        string Written_Entry = Console.ReadLine();

        string journal_entry = $"{dateText} {questions[number]}: {Written_Entry}";
        
        List<string> entries_list = new List<string>();
        
        entries_list.Add(journal_entry);
        Console.WriteLine("Would you like to save the changes?(y/n) ");
        string answer = Console.ReadLine();
        if (answer == "y")
        {
            string file = "Records.txt";

            using (StreamWriter txt = File.AppendText(file)){
                txt.Write($"{entries_list[0]}\n");
            }
        }
        
        
    }






}














