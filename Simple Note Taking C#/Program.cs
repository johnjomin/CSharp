using System;
using System.Collections.Generic;

namespace NoteTakingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> notes = new List<string>();

            while (true)
            {
                Console.WriteLine("Note Taking Application");
                Console.WriteLine("1. Add Note");
                Console.WriteLine("2. View Notes");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your note: ");
                        string note = Console.ReadLine();
                        notes.Add(note);
                        Console.WriteLine("Note added successfully!");
                        break;
                    case 2:
                        Console.WriteLine("Your Notes:");
                        foreach (string n in notes)
                        {
                            Console.WriteLine(n);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Exiting the application...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}