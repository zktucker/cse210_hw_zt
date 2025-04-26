using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int intGradeP = int.Parse(gradePercentage);
        string letter = "Error";
        if (intGradeP >= 90)
        {
            letter = "A";
        }
        else if (intGradeP >= 80)
        {
            letter = "B";
        }
        else if (intGradeP >= 70)
        {
            letter = "C";
        }
        else if (intGradeP >= 60)
        {
            letter = "D";
        }
        else if (intGradeP < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter} ");

        if (intGradeP >= 70)
        {
            Console.WriteLine("Congratulations! You are passing the class");
        }
        else if (intGradeP < 70)
        {
            Console.WriteLine("You are currently failing the class. Keep working to boost your grade");

        }
    }
}
