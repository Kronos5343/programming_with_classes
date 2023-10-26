using System;

class Word
{
     private string text;
     
     private bool _ishidden;

     public Word(string text, bool _ishidden)
     {
      this.text = text;
     }

   public void Display()
   {
      Console.Write($"{text} ");
   }

}