using System;

class Scripture
{
    public Reference reference;
    public List<Word> words;

    public Scripture(Reference reference, string scripture){
        this.reference = reference;
        this.words = new List<Word>();
        foreach(var thing in scripture.Split(" "))
        {
            Word variable = new Word(thing, false);
            words.Add(variable);
        }
        
    }

    public void Display()
    {
        reference.Display();
        foreach(var word in words)
        {
            word.Display();
        }
    }
    public void hide_words()
    {

    }
}