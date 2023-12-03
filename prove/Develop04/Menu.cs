using System;

class Menu_system
{

    public void menu()
    {
        string answer = "0";
        while (answer != "4")
        {
            Console.WriteLine("Menu:\n1. Breathing\n2. Reflection\n3. Listing\n4. Exit\nWhat activity would you like to do? ");
            string response = Console.ReadLine();

            if (response == "1")
            {
                Breathing exercise = new Breathing();
                exercise.breathing_exercise();
            }

            else if (response == "2")
            {
                Reflection exercise = new Reflection();
                exercise.reflection_exercise();
            }

            else if (response == "3")
            {
                Listing exercise = new Listing();
                exercise.listening_exercise();
            }

            else if (response == "4")
            {
                answer = "4";
            }

            else
            {
                Console.WriteLine("Please choose a valid option!");
            }


        }



    }
}