using System;
using System.Formats.Asn1;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;


public class menu_system
{
    public void Display()
    {
        int Breakout_Answer = 0;
        while (Breakout_Answer != 5)
        {
            Console.WriteLine("Choose your option:\n1.Write\n2.Display\n3.Load\n4.Quit ");
            int answer = int.Parse(Console.ReadLine());
            

            if (answer == 1)
            {
                Journal entry = new Journal();
                entry.Write();

            }
            else if (answer == 2)
            {
                Journal entry = new Journal();
                entry.display();
            }
            else if (answer == 3)
            {
                Journal entry = new Journal();
                entry.load();
            }
            else
            {
                Breakout_Answer = 5;
            }
        }
    
    
    }










}








