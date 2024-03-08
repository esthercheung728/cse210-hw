using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\n Welcome to the Journal Program!");
            Console.WriteLine("Journal App Menu:");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load the Journal from a file");
            Console.WriteLine("4. Save the journal to a file");
            Console.WriteLine("5. Clear the journal");
            Console.WriteLine("6. Display the count of entries");
            Console.WriteLine("7. Quit");

            Console.Write("What would you like to do? Please select an option (1-7): ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                // Write a new entry
                case 1:
                    theJournal.NewEntry();
                    Console.WriteLine();
                    break;

                // string prompt = PromptGenerator.GetRandomPrompt();
                // Console.WriteLine($"Prompt: {prompt}");
                // Console.Write("Enter your response: ");
                // string response = Console.ReadLine();
                // journal.AddEntry(prompt, response);
                // break;

                // Display the journal
                case 2:
                    // theJournal.DisplayAll();
                    // Console.WriteLine();
                    // break;

                    if (theJournal.EntriesCount() == 0)
                    {
                        Console.WriteLine("The journal is empty. Add some entries first.");
                    }
                    else
                    {
                        theJournal.DisplayAll();
                    }
                    break;

                // Load the Journal from a file
                case 3:
                    Console.Write("Enter the file name to load: ");
                    string loadFileName = Console.ReadLine();
                    theJournal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal saved successfully.");
                    Console.WriteLine();
                    break;

                // Save the journal to a file
                case 4:
                    Console.Write("Enter the file name to save: ");
                    string saveFileName = Console.ReadLine();
                    theJournal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal loaded successfully.");
                    Console.WriteLine();
                    break;


                // Clear the journal
                case 5:
                    theJournal.ClearJournal();
                    Console.WriteLine("Journal cleared successfully.");
                    Console.WriteLine();
                    break;

                // Display the count of entries
                case 6:
                    int count = theJournal.EntriesCount();
                    Console.WriteLine($"Number of entries in the journal: {count}");
                    Console.WriteLine();
                    break;


                // Quit
                case 7:
                    isRunning = false;
                    Console.WriteLine("Thank you. Have a nice day!");
                    Console.WriteLine();
                    break;



                default:
                    Console.WriteLine("Invalid choice. Please select a valid option (1-7).");
                    break;
            }
        }

    }
}