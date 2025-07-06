using System;

class Program
{
    static void Main(string[] args)
    {

/*
 Name: Volodymyr Denys
 Title: IT-1050 - Lab 1
*/

// Step 2
Console.WriteLine("Volodymyr Denys");
Console.WriteLine("IT-1050 - Lab 1");

// Step 3
int favoriteNumber = 7;
string favoriteLang = "C#";
double programsWritten = 15.5;
bool hasExperience = true;

Console.WriteLine("Favorite number: " + favoriteNumber);
Console.WriteLine("Favorite programming language: " + favoriteLang);
Console.WriteLine("Programs written before this: " + programsWritten);
Console.WriteLine("Have programming experience: " + hasExperience);

// Step 4
const string schoolName = "Cuyahoga Community College";
Console.WriteLine("School name: " + schoolName);

// Step 5
double doubleValue = 9.78;
int intValue = (int)doubleValue;

string intToString = Convert.ToString(intValue);
bool boolValue = true;
string boolToString = Convert.ToString(boolValue);

Console.WriteLine("double: " + doubleValue);
Console.WriteLine("int: " + intValue);
Console.WriteLine("int to string: " + intToString);
Console.WriteLine("bool to string: " + boolToString);

// Step 6
Console.WriteLine("Enter your name:");
string userName = Console.ReadLine();

Console.WriteLine("Enter your age:");
int userAge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hello " + userName + "! You are " + userAge + " years old.");

// Step 7
int num1 = 10;
int num2 = 5;

int addition = num1 + num2 + 10;
int subtraction = num1 - num2 - 2;
int multiplication = (num1 * num2) * 3;
int division = (num1 / num2) / 2;
int modulus = (num1 % num2) % 2;

Console.WriteLine("Addition result: " + addition);
Console.WriteLine("Subtraction result: " + subtraction);
Console.WriteLine("Multiplication result: " + multiplication);
Console.WriteLine("Division result: " + division);
Console.WriteLine("Modulus result: " + modulus);

// Step 8
float floatValue = 1.123456789f;
double doubleValue2 = 1.123456789;

Console.WriteLine("Float value: " + floatValue);
Console.WriteLine("Double value: " + doubleValue2);

// Step 9
int number = 10;
number++;
Console.WriteLine("After increment: " + number);
number--;
Console.WriteLine("After decrement: " + number);
    }
}
