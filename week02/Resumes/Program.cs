using System;

class Program
{
    static void Main(string[] args)
    {

        //Creating the instance of the first job

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //Creating the instance of the second job

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Creating the instance of the resume

        Resume myResume = new Resume();
        myResume._name = "Amani Daniel";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Calling the Display()method
        myResume.Display();

        


    }
}