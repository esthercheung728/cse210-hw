using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Senior Account Clerk";
        job1._company = "NEHK";
        job1._startYear = 2018;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Assistant Supervisor";
        job2._company = "SOGO";
        job2._startYear = 2022;
        job2._endYear = 2023;


        Resume myResume = new Resume();
        myResume._name = "Esther Cheung";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}