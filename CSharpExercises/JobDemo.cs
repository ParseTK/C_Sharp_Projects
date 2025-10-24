using System;
using static System.Console;
using System.Globalization;
/*
Create an application named JobDemo that declares and uses Job objects. The Job class holds job information for a home repair service. The class has five properties that include:

JobNumber - The job number - int
Customer - The customer name - string
Description - The job description - string
Hours - The estimated hours - double
price - The price for the job

Create a constructor that requires parameters for all the data except price. Follow the order and data type above. Include auto-implemented properties for the job number, 
customer name, and job description, but not for hours or price; the price field value is calculated as estimated hours times $45.00 ($45.00 / hour) whenever the hours value is set.

Also create the following methods for theJob class:

An Equals() method that determines two Jobs are equal if they have the same job number
A GetHashCode() method that returns the job number
A ToString() method that returns a string containing all job information in the following format:
*/
class JobDemo3
{
    static void Main()
    {
        const int MAXJOBS = 5;
        int counter = 0;
        var jobs = new RushJob[MAXJOBS];

        while (counter < MAXJOBS)
        {
            Write("Job number ");
            int jobNumber = Convert.ToInt32(ReadLine());

            if (Array.Exists(jobs, job => job != null && job.JobNumber == jobNumber))
            {
                WriteLine("Please reenter");
                continue;
            }

            Write("Name ");
            string customer = ReadLine();

            Write("Job Desc ");
            string description = ReadLine();

            Write("Hours worked ");
            double hours = Convert.ToDouble(ReadLine());

            jobs[counter++] = new RushJob(jobNumber, customer, description, hours);
        }

        double totalPrice = 0;
        foreach (var job in jobs)
        {
            WriteLine(job + "\n");
            totalPrice += job.Price;
        }

        WriteLine($"Total for all jobs is {totalPrice.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
    }
}

public class Job
{
    public int JobNumber { get; set; }
    public string Customer { get; set; }
    public string Description { get; set; }
    private double hours;
    private double price;

    public double Hours
    {
        get => hours;
        set { hours = value; price = hours * 45.00; }
    }

    public virtual double Price => price;

    public Job(int jobNumber, string customer, string description, double hours)
    {
        JobNumber = jobNumber;
        Customer = customer;
        Description = description;
        Hours = hours;
    }

    public override bool Equals(object oJob) =>
        oJob is Job targetJob && JobNumber == targetJob.JobNumber;

    public override int GetHashCode() => JobNumber;

    public override string ToString() =>
        $"Job {JobNumber} {Customer} {Description} {Hours} hours @$45.00 per hour. Total price is {Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
}

public class RushJob : Job
{
    private const double Premium = 150.00;

    public RushJob(int jobNumber, string customer, string description, double hours)
        : base(jobNumber, customer, description, hours) { }

    public override double Price => base.Price + Premium;

    public override string ToString() =>
        $"RushJob {JobNumber} {Customer} {Description} {Hours} hours @$45.00 per hour. Rush job adds 150 premium. Total price is {Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
}
