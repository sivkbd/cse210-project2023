using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");



        Job job1 = new Job();
        job1._jobTitle = "Site Clerk";
        job1._company = "Asla Construction";
        job1._startYear = 2016;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Checkers";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Siviwe Kibido";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}