using System;

class Entries
{
    public string[] date;
    public string[] question;
    public string[] entry;

    public void ConstructEntries(string file_name)
    {
        string[] lines = File.ReadAllLines(file_name);

        foreach (string line in lines)
        {
            string[] date1 = line.Split("*");
            string[] question1 = line.Split(":");
            string[] entry1 = line.Split("~");

            this.date = date1;
            this.question = question1;
            this.entry = entry1;
        }
    }
}