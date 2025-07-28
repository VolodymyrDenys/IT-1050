using System;

class Car
{
    public string model;
    public string color;
    public int year;

    // Method to display car details
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    // Problem 1: Method with no parameters
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    // Problem 2: Method with parameters
    public void Drive(int miles)
    {
        Console.WriteLine($"The car drove {miles} miles.");
    }

    // Problem 3: Method with return value
    public string GetDescription()
    {
        return $"{year} {color} {model}";
    }

    // Problem 4: Method that updates a field
    public void Repaint(string newColor)
    {
        color = newColor;
        Console.WriteLine($"The car has been repainted to {newColor}.");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        // Calling Display method
        myCar.Display();

        // Problem 1: Call Start()
        myCar.Start();

        // Problem 2: Call Drive()
        myCar.Drive(50);

        // Problem 3: Call GetDescription() and print the result
        string description = myCar.GetDescription();
        Console.WriteLine("Description: " + description);

        // Problem 4: Call Repaint() and confirm color update
        myCar.Repaint("Red");
        myCar.Display(); // To confirm updated color
    }
}
