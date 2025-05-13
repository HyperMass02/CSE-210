using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }

    public void CreateResume()
    {
        Resume resume = new Resume();
        Console.Write("Enter your name: ");
        resume._name = Console.ReadLine();

        string addMoreJobs = "y";
        while (addMoreJobs.ToLower() == "y")
        {
            Job job = new Job();
            Console.Write("Enter job title: ");
            job._jobTitle = Console.ReadLine();
            Console.Write("Enter company name: ");
            job._company = Console.ReadLine();
            Console.Write("Enter start year: ");
            job._startYear = int.Parse(Console.ReadLine());
            Console.Write("Enter end year: ");
            job._endYear = int.Parse(Console.ReadLine());

            resume._jobs.Add(job);

            Console.Write("Do you want to add another job? (y/n): ");
            addMoreJobs = Console.ReadLine();
        }

    }
}
