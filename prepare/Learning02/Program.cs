using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._jobtitle = "Computer Engineer";
       job1._company = "IBM";
       job1._startyear = 2018;
       job1._endyear = 2024;

       Job job2 = new Job();
       job2._jobtitle = "Computer Engineer B";
       job2._company = "IBM B";
       job2._startyear = 2018;
       job2._endyear = 2024;

       //job1.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Victor Granado";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    
    }
}

