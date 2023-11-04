using System;
using System.Security.Cryptography.X509Certificates;

class Commonalities
{
    public void ending()
    {
        Console.WriteLine("Thanks for completing this exercise!\n");
    }
    public int time()
    {
        Console.WriteLine("How long would you like to do the activity for in seconds? ");
        int answer = int.Parse(Console.ReadLine());
        return answer;
    }

    public void get_ready()
    {
        int timer = 0;
        while (timer != 4)
        {
            Console.Write("Get Ready... >");
            Thread.Sleep(400);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); 
            Console.Write("Get Ready... |");
            Thread.Sleep(400);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Get Ready... <");
            Thread.Sleep(400);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("Get Ready... |");
            Thread.Sleep(400);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            timer ++;
        }
        Console.WriteLine("\b\b\b\b\b\b\b");
    }
}

class Breathing
{
    public void breathing_exercise()
    {
        Console.WriteLine("Welcome to the Breathing activity.");
        Console.WriteLine("In this exercise you will take time to meditate and breath so that you can find inner peace and tranquility.\n");

        Commonalities Parent = new Commonalities();
        int answer = Parent.time();
        Parent.get_ready();

        int finish_number = 0;
        while (finish_number != 1)
        {
            while (answer > 15)
            {
                int timer = 4;
                while (timer != 0)
                {
                Console.Write($"Breath in... {timer}");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); 
                timer --;
                }
                Console.Write("Hold...        ");
                Thread.Sleep(4000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");

                timer = 4;
                while (timer != 0)
                {
                Console.Write($"Breath out... {timer}");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                timer --;
                }
                Console.Write("Hold...         ");
                Thread.Sleep(3000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                answer = answer - 15;
            }
            
            while (answer != 0)
            {
                Console.Write($"Relax... {answer} ");
                Thread.Sleep(1000);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                answer --;
            }
            
            Parent.ending();
            finish_number = 1;
        }

        
    }

}




class Reflection
{
    static string[] first_questions = new string[] 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    static string[] second_questions = new string[] 
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    static Random randomGenerator = new Random();
    int starting_question = randomGenerator.Next(first_questions.Length);
    int follow_up_question = randomGenerator.Next(second_questions.Length);

    public void reflection_exercise()
    {
        Console.WriteLine("Welcome to the Reflection activity.");
        Console.WriteLine("In this exercise you will take time to reflect on yourself and help you recognize how far you've come, and the power you have in yourlife.\n");

        Commonalities Parent = new Commonalities();
        int answer = Parent.time();
        Parent.get_ready();

        int finishing_number = 0;
        while (finishing_number != 1)
        {
            while (answer > 15)
            {
                Console.WriteLine($"{first_questions[starting_question]}");
                int timer = 7;
                while (timer != 0)
                    {
                    Console.Write($"Think... {timer}  ");
                    Thread.Sleep(1000);
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    timer --;
                    }
                
                Console.WriteLine($"{second_questions[follow_up_question]}");
                timer = 7;
                while (timer != 0)
                    {
                    Console.Write($"Think... {timer}  ");
                    Thread.Sleep(1000);
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    timer --;
                    }
                    Thread.Sleep(1000);
                    answer = answer - 15;
            }


            while (answer != 0)
                {
                    Console.Write($"Relax... {answer} ");
                    Thread.Sleep(1000);
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    answer --;
                }

            Parent.ending();
            finishing_number = 1;
        }

    }

}






class Listing
{
    static string[] prompts = new string[] 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    static Random randomnumgen = new Random();
    int random_prompt = randomnumgen.Next(prompts.Length);

    public void listening_exercise()
    {
        Console.WriteLine("Welcome to the Listening activity.");
        Console.WriteLine("In this exercise you will take time to look back on the good things in your life.\n");

        Commonalities Parent = new Commonalities();
        int answer = Parent.time();
        Parent.get_ready();

        Thread.Sleep(3000);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(answer);
        
        int inputs = 0;
        DateTime currenttime = DateTime.Now;
        Console.WriteLine($"--- {prompts[random_prompt]} ---");
        int breakout = 0;
        while (breakout != 1)
        {
            if (currenttime < futureTime)
            {;
                currenttime = DateTime.Now;
                Console.ReadLine();
                inputs ++;
            }
            else
            {
               Console.WriteLine($"Congrats! You had {inputs} inputs!");
               breakout = 1;
            }
        }
    }
}
