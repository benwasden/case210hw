using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();

        Swimming swimming = new Swimming("03 Nov 2024", 10, 40);
        Swimming swimming2 = new Swimming("15 June 2014", 5, 6);
        Swimming swimming3 = new Swimming("7 May 2017", 15, 35);

        activities.Add(swimming);
        activities.Add(swimming2);
        activities.Add(swimming3);


        Cycling cycling = new Cycling("10 Dec 2015", 30, 7);
        Cycling cycling2 = new Cycling("14 July 2021", 20, 5);
        Cycling cycling3 = new Cycling("20 Feb 2020", 15, 4);

        activities.Add(cycling);
        activities.Add(cycling2);
        activities.Add(cycling3);


        Running running = new Running("04 Sept 2012", 30, 3);
        Running running2 = new Running("10 Jan 2014", 8, 1);
        Running running3 = new Running("30 June 2023", 20, 3);
        activities.Add(running);
        activities.Add(running2);
        activities.Add(running3);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
            Console.WriteLine();
        }
    }
}