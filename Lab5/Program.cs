using System;

// Step 1 – Create a Base Class
public class Animal
{
    // Virtual method to be overridden by derived classes
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

// Step 2 – Create Derived Class: Cat
public class Cat : Animal
{
    // Override the base method to provide specific implementation
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

// Step 2 – Create Derived Class: Dog
public class Dog : Animal
{
    // Override the base method to provide specific implementation
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 3 – Test in Main()

        // Create objects using the base class reference
        Animal myAnimal = new Animal();
        Animal myCat = new Cat();
        Animal myDog = new Dog();

        // Call the method on each object to demonstrate runtime polymorphism
        myAnimal.animalSound();  // Output: The animal makes a sound
        myCat.animalSound();     // Output: The cat says: meow
        myDog.animalSound();     // Output: The dog says: bow wow
    }
}
