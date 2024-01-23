using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");


        Job job1 = new Job(); //new var named Job with datatype job

        //Input information
        job1._jobTitle = "TV Remote - Engineer";
        job1._company = "LifeRock";
        job1._startYear = 1988;
        job1._endYear = 2023;

        //Repeat
        Job job2 = new Job();

        job2._jobTitle = "Product-Tester";
        job2._company = "Walmart";
        job2._startYear = 2023;
        job2._endYear = 2050;

        //New var named myResume with datatype Resume
        Resume myResume = new Resume();

        myResume._name = "Sir Robard the Old";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}