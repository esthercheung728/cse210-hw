using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
            if (percent >= 97)
            {
                sign = "+";
            }
            else if (percent <= 92)
            {
                sign = "-";
            }
        }
        else if (percent >= 80)
        {
            letter = "B";
            if (percent >= 87)
            {
                sign = "+";
            }
            else if (percent <= 82)
            {
                sign = "-";
            }
        }
        else if (percent >= 70)
        {
            letter = "C";
            if (percent >= 77)
            {
                sign = "+";
            }
            else if (percent <= 72)
            {
                sign = "-";
            }
        }
        else if (percent >= 60)
        {
            letter = "D";
            if (percent >= 67)
            {
                sign = "+";
            }
            else if (percent <= 62)
            {
                sign = "-";
            }
        }
        else
        {
            letter = "F";
        }

        if (letter == "A" && sign == "+")
        {
            Console.WriteLine("Your grade is: A");
        }
        else if (letter == "A" && sign == "-")
        {
            Console.WriteLine("Your grade is: A-");
        }
        else if (letter == "F")
        {
            Console.WriteLine("Your grade is: F");
        }
        else
        {
            Console.WriteLine($"Your grade is: {letter}{sign}");
        }

        if (percent >= 70)
        {
            Console.WriteLine("You passed! Every step you take is a step closer to your dreams. Keep moving forward.");
        }
        else
        {
            Console.WriteLine("Stay focused and stay positive. Success is just around the corner.");
        }
    }
}