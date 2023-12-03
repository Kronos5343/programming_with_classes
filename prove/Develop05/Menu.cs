using System;

class Menu_system
{
    List<Goal> listOfGoals = new List<Goal>();
    public void menu1()
    {
        string answer = "0";
        while (answer != "6")
        {
            Console.WriteLine(" Menu:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Exit\nPlease choose an option: ");
            string response = Console.ReadLine();

            if (response == "1")
            {
                menu2();
            }

            else if (response == "2")
            {
                
                foreach (var goal in listOfGoals)
                {
                    Console.WriteLine($"{goal}");
                }
            }

            else if (response == "3")
            {
                Goal save = new Goal();
                save.write_to_file();
            }

            else if (response == "4")
            {
                
            }

            else if (response == "5")
            {
                
            }

            else if (response == "6")
            {
                answer = "6";
            }

            else
            {
                Console.WriteLine("Please choose a valid option!");
            }


        }



    }

    public void menu2()
    {
        string answer = "0";
        while (answer != "4")
        {
            Console.WriteLine(" Menu:\n1. Checklist\n2. Simple\n3. Eternal\n4. Go Back\nWhich goal would you like to make? ");
            string response = Console.ReadLine();

            if (response == "1")
            {
                Checklist goal = Checklist.make_checklist_goal();
                listOfGoals.Add(goal);
            }

            else if (response == "2")
            {
                Simple goal = Simple.make_simple_goal();
                listOfGoals.Add(goal);

            }

            else if (response == "3")
            {
                Eternal goal = Eternal.make_eternal_goal();
                listOfGoals.Add(goal);
        
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