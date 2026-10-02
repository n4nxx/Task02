using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Select a program to run:");
Console.WriteLine("1. Dice Game (Imperative)");
Console.WriteLine("2. Student Information (Declarative)");
Console.Write("Option: ");

string opcion = Console.ReadLine();

if (opcion == "1")
{

    Console.WriteLine("--- Dice Game ---");

    Random random = new Random();
    int userRoll;
    int computerRoll;

    do
    {

        userRoll = random.Next(1, 7); 
        computerRoll = random.Next(1, 7);

        Console.WriteLine($"User's roll: {userRoll}");
        Console.WriteLine($"Computer's roll: {computerRoll}");

        //empate
        if (userRoll == computerRoll)
        {
            Console.WriteLine("Tie\n");
        }

    } while (userRoll == computerRoll); 

    //gano
    if (userRoll > computerRoll)
    {
        Console.WriteLine("Congratulations, you won!");
    }
    //pierdo
    else
    {
        Console.WriteLine("The computer wins");
    }
}
else if (opcion == "2")
{

    Console.WriteLine("--- Student Information ---");
    List<double> grades = new List<double>();

    
    for (int i = 1; i <= 5; i++)
    {
        Console.Write($"Introduce the mark {i}: ");
        double.TryParse(Console.ReadLine(), out double grade);
        grades.Add(grade);
    }

    
    double maxGrade = grades.Max();
    double minGrade = grades.Min();
    double averageGrade = grades.Average();

    
    Console.WriteLine("\n--- Summary of Grades ---");
    Console.WriteLine($"Highest grade: {maxGrade}");
    Console.WriteLine($"Lowest grade: {minGrade}");
    Console.WriteLine($"Average grade: {averageGrade}");
}
else
{
    Console.WriteLine("Invalid option.");
}