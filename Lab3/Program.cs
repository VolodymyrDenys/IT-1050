using System;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1:
        Console.WriteLine("Problem 1: Numbers from 1 to 10");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Problem 2:
        Console.WriteLine("\nProblem 2: Even numbers from 1 to 20");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Problem 3:
        Console.WriteLine("\nProblem 3: Countdown from 5 to 1");
        int count = 5;
        while (count >= 1)
        {
            Console.WriteLine(count);
            count--;
        }

        // Problem 4:
        Console.WriteLine("\nProblem 4: Multiples of 10 from 10 to 1000");
        int num = 10;
        while (num <= 1000)
        {
            Console.WriteLine(num);
            num += 10;
        }

        // Problem 5:
        Console.WriteLine("\nProblem 5: Seasons of the year");
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }

        // Problem 6:
        Console.WriteLine("\nProblem 6: Days of the week (1–7)");
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number from 1 to 7: ");
        string input = Console.ReadLine();
        int dayNumber;
        if (int.TryParse(input, out dayNumber) && dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine("The day is: " + days[dayNumber - 1]);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number from 1 to 7.");
        }

        // Problem 7:
        Console.WriteLine("\nProblem 7: Favorite books and authors");
        string[] books = { "The Hobbit", "1984", "To Kill a Mockingbird" };
        string[] authors = { "J.R.R. Tolkien", "George Orwell", "Harper Lee" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{books[i]} by {authors[i]}");
        }

        // Problem 8:
        Console.WriteLine("\nProblem 8: Temperature tracker");
        int[] temperatures = { 72, 85, 68, 90, 77 };
        Array.Sort(temperatures);
        Console.WriteLine("Temperatures in ascending order:");
        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        }
        Console.WriteLine("Lowest temperature: " + temperatures[0]);
        Console.WriteLine("Highest temperature: " + temperatures[temperatures.Length - 1]);

        // Problem 9:
        Console.WriteLine("\nProblem 9: Reverse countdown");
        int[] countdown = { 5, 4, 3, 2, 1 };
        Array.Reverse(countdown);
        Console.WriteLine("After reversing:");
        for (int i = 0; i < countdown.Length; i++)
        {
            Console.WriteLine(countdown[i]);
        }
    }
}
