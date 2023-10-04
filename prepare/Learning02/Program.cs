using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._Companytitle = "Nvidia";
        job1._Jobtitle = "Hardware Engineer";
        job1._Startyear = 2000;
        job1._Endyear = 2023;


        Persons_Resume Myresume = new Persons_Resume();
        Myresume._Person_name = "Carl Desmond";

        Myresume._jobs.Add(job1);

        Myresume.Display();
    }

    public class Job
    {
        public string _Companytitle;
        public string _Jobtitle;
        public int _Startyear;
        public int _Endyear;

        public void Printinfo()
        {
            Console.WriteLine($"{_Companytitle}\n({_Jobtitle})\n{_Startyear}-{_Endyear}");
        }
    }

    public class Persons_Resume
    {
        public string _Person_name;
        public List<Job> _jobs = new List<Job>();

        public void Display()
        {
            Console.WriteLine($"Name: {_Person_name}");
            Console.WriteLine("Jobs: ");

            foreach (Job Display_job in _jobs)
            {
                Display_job.Printinfo();
            }
        }
    }

}








