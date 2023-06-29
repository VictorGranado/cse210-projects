using System;
using System.Collections.Generic;

namespace Develop05
{
    public class Program
    {
        private static List<Goal> goals = new List<Goal>();
        private static int score = 0;

        public static void Main()
        {
            while (true)
            {
                DisplayMenu();
                Console.WriteLine("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateNewGoal();
                        break;
                    case 2:
                        SaveGoals();
                        break;
                    case 3:
                        LoadGoals();
                        break;
                    case 4:
                        SeeCurrentGoals();
                        break;
                    case 5:
                        CompleteGoal();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Your score: " + score);
                Console.WriteLine();
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("=== Eternal Quest ===");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Save goals");
            Console.WriteLine("3. Load goals");
            Console.WriteLine("4. See current goals");
            Console.WriteLine("5. Complete goal");
            Console.WriteLine("6. Exit");
        }

        private static void CreateNewGoal()
        {
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Enter the type of goal: ");
            int type = int.Parse(Console.ReadLine());

            Console.Write("Enter the goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter a brief description: ");
            string description = Console.ReadLine();

            Goal goal;
            switch (type)
            {
                case 1:
                    goal = new SimpleGoal(name, description);
                    break;
                case 2:
                    goal = new EternalGoal(name, description);
                    break;
                case 3:
                    Console.Write("Enter the item count: ");
                    int itemCount = int.Parse(Console.ReadLine());
                    goal = new ChecklistGoal(name, description, itemCount);
                    break;
                default:
                    Console.WriteLine("Invalid goal type. Goal creation failed.");
                    return;
            }

            goals.Add(goal);
        }

        private static void SaveGoals()
        {
            // Implement the logic to save goals to a file
            Console.WriteLine("Goals saved.");
        }

        private static void LoadGoals()
        {
            // Implement the logic to load goals from a file
            Console.WriteLine("Goals loaded.");
        }

        private static void SeeCurrentGoals()
        {
            Console.WriteLine("=== Current Goals ===");
            foreach (Goal goal in goals)
            {
                string completionStatus = goal.Completed ? "[X]" : "[ ]";

                if (goal is ChecklistGoal checklistGoal)
                {
                    completionStatus += $" Completed {checklistGoal.CompletedCount}/{checklistGoal.ItemCount} times";
                }

                Console.WriteLine($"{completionStatus} - {goal.Name} - {goal.Description}");
            }
        }

        private static void CompleteGoal()
        {
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals available to complete.");
                return;
            }

            Console.WriteLine("Select a goal to complete:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].Name}");
            }

            Console.Write("Enter the goal number: ");
            int goalNumber = int.Parse(Console.ReadLine());

            if (goalNumber <= 0 || goalNumber > goals.Count)
            {
                Console.WriteLine("Invalid goal number.");
                return;
            }

            Goal selectedGoal = goals[goalNumber - 1];
            selectedGoal.Complete();
            score += selectedGoal.Points;

            Console.WriteLine("Goal completed! Points added to your score.");
        }
    }
 
}