namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        // Part 1.
        int a = 10;
        int b = 5;
        int c = 15;

        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < c: " + (a < c));
        Console.WriteLine("a > b && a > c: " + (a > b && a > c));
        Console.WriteLine("a > b || a > c: " + (a > b || a > c));

        // Part 2.
        bool isRaining = true;
        bool haveUmbrella = false;

        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }

        // Part 3.
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (age >= 5 && age <= 12)
        {
            Console.WriteLine("Child ticket: $5");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("Standard ticket: $10");
        }
        else
        {
            Console.WriteLine("Senior ticket: $6");
        }

        // Part 4.
        Console.Write("Enter a number (1-7): ");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;
        }
    }
}
