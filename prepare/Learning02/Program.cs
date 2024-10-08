using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "School District";
        job1._jobTitle = "Computer Technician";
        job1._startYear = 2019;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Developer";
        job2._startYear = 2005;
        job2._endYear = 2015;

        Resume myResume = new Resume();
        myResume._name = "Ben Wasden";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}