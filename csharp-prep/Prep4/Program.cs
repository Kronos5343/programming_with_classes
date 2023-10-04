using System;
using System.Formats.Asn1;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers_list = new List<int>();

        

        int number_answer = 1;

        while (number_answer != 0)
        {

            Console.Write("Pick a number and when your finished type 0: ");
            string answer = Console.ReadLine();
            number_answer = int.Parse(answer);
            
            if (number_answer != 0)
            {
                numbers_list.Add(number_answer);
            }
        }
        
        int number_total = 0;
            foreach (int number in numbers_list)
            {
                number_total += number;
            }

        Console.WriteLine($"The total amount of numbers is: {number_total}");

        float number_adverage = ((float)number_total) / numbers_list.Count;
        Console.WriteLine($"The adverage is: {number_adverage}");

        int max_number = numbers_list[0];
        foreach (int number in numbers_list)
        {
            if (number > max_number)
            {
                max_number = number;
            }
        }

        Console.WriteLine($"The highest number value is: {max_number}");

        int min_number = numbers_list[0];
        foreach (int number in numbers_list)
        {
            if (number < min_number)
            {
                if (number > 0)
                {
                    min_number = number;
                }
            }
        }

        Console.WriteLine($"The lowest number value is: {min_number}");




    }
}