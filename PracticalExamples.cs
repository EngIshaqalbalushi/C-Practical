
using System;
using System.IO;

class Program
{
    // ---------- Functions ----------
    static int AddTwoNumbers(int a, int b) => a + b;

    static bool IsEven(int number) => number % 2 == 0;

    static void GreetUser(string name) => Console.WriteLine($"Welcome, {name}!");

    static double Max(double a, double b) => (a > b) ? a : b;

    static int Factorial(int n) => (n <= 1) ? 1 : n * Factorial(n - 1);

    // ---------- Main ----------
    static void Main()
    {
        // ---------- Data Types ----------
        string name = "Ali";
        int age = 25;
        double height = 1.75;
        Console.WriteLine($"{name}, {age}, {height}");

        Console.Write("Enter your age: ");
        int userAge = int.Parse(Console.ReadLine());
        Console.WriteLine($"You are {userAge} years old");

        const double Pi = 3.1416;
        double radius = 5;
        Console.WriteLine("Area: " + (Pi * radius * radius));

        float f1 = 2.5f, f2 = 3.3f;
        Console.WriteLine($"Sum: {(f1 + f2):0.00}");

        var greeting = "Hello";
        Console.WriteLine(greeting.GetType());

        // ---------- Loops ----------
        for (int i = 1; i <= 10; i++) Console.WriteLine(i);

        int num = 2;
        while (num <= 20)
        {
            Console.WriteLine(num);
            num += 2;
        }

        string input;
        do
        {
            Console.Write("Enter password: ");
            input = Console.ReadLine();
        } while (input != "admin");

        int sum = 0;
        for (int i = 1; i <= 100; i++) sum += i;
        Console.WriteLine("Sum 1–100: " + sum);

        string[] names = { "Ali", "Sara", "Omar" };
        foreach (string n in names) Console.WriteLine(n);

        // ---------- Arrays ----------
        int[] arr = { 5, 10, 15, 20 };
        Console.WriteLine("First: " + arr[0] + ", Last: " + arr[arr.Length - 1]);

        int max = arr[0];
        foreach (int a in arr) if (a > max) max = a;
        Console.WriteLine("Max: " + max);

        string[] inputNames = new string[3];
        for (int i = 0; i < 3; i++) inputNames[i] = Console.ReadLine();
        Array.Reverse(inputNames);
        foreach (var n in inputNames) Console.WriteLine(n);

        int[] nums = { 3, 6, 9, 12 };
        int total = 0;
        foreach (int val in nums) total += val;
        Console.WriteLine("Sum: " + total);

        Console.Write("Array size: ");
        int size = int.Parse(Console.ReadLine());
        int[] values = new int[size];
        int oddCount = 0;
        for (int i = 0; i < size; i++)
        {
            values[i] = int.Parse(Console.ReadLine());
            if (values[i] % 2 != 0) oddCount++;
        }
        Console.WriteLine("Odd count: " + oddCount);

        // ---------- Exceptions ----------
        try
        {
            int x = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }

        try
        {
            int a = 10, b = 0;
            Console.WriteLine(a / b);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }

        try
        {
            string path = "file.txt";
            if (File.Exists(path)) Console.WriteLine(File.ReadAllText(path));
            else throw new FileNotFoundException();
        }
        catch
        {
            Console.WriteLine("File not found.");
        }

        try
        {
            int.Parse("abc");
        }
        catch
        {
            Console.WriteLine("Error");
        }
        finally
        {
            Console.WriteLine("Finished");
        }

        try
        {
            Console.Write("Enter a number: ");
            int numInput = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + numInput);
        }
        catch
        {
            Console.WriteLine("Invalid input.");
        }

        // ---------- Operators ----------
        int op1 = int.Parse(Console.ReadLine());
        int op2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Sum: {op1 + op2}, Diff: {op1 - op2}, Product: {op1 * op2}, Quotient: {op1 / op2}");

        int check = 12;
        if (check > 10 && check % 2 == 0) Console.WriteLine("Even and >10");

        int checkAge = 20;
        string result = (checkAge >= 18) ? "Adult" : "Minor";
        Console.WriteLine(result);

        int valInc = 5;
        valInc++;
        Console.WriteLine(valInc);

        string s1 = "hello", s2 = "hello";
        Console.WriteLine(s1 == s2);

        // ---------- Access Modifiers ----------
        Person p = new Person();
        p.SetName("John");
        Console.WriteLine(p.GetName());

        MyClass my = new MyClass();
        my.Show();

        Counter c1 = new Counter();
        Counter c2 = new Counter();
        Console.WriteLine(Counter.count);

        Derived d = new Derived();
        d.CallBase();

        void DemoScope()
        {
            int local = 10;
            Console.WriteLine(local);
        }
        DemoScope();

        // ---------- Input/Output ----------
        Console.Write("Name: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}!");

        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum: " + (n1 + n2));

        Console.Write("Favorite color: ");
        string color = Console.ReadLine();
        Console.WriteLine($"Wow, {color} is nice!");

        Console.Write("Hello ");
        Console.Write("World");

        var key = Console.ReadKey();
        Console.WriteLine($"
You pressed: {key.KeyChar}");

        // ---------- File Handling ----------
        File.WriteAllText("welcome.txt", "Welcome to the app!");

        if (File.Exists("file.txt")) Console.WriteLine("Exists");
        else Console.WriteLine("Not found");

        File.AppendAllText("log.txt", "New log entry\n");

        string notes = File.ReadAllText("notes.txt");
        Console.WriteLine(notes);

        string[] nameList = File.ReadAllLines("names.txt");
        for (int i = 0; i < nameList.Length; i++)
            Console.WriteLine($"{i + 1}: {nameList[i]}");

        // ---------- Syntax ----------
        Console.WriteLine("Hello, C#");

        string msg = "Hi";
        int number = 42;
        bool active = true;
        Console.WriteLine($"{msg}, {number}, {active}");

        for (int i = 1; i <= 5; i++) Console.WriteLine(i);

        int numCheck = -5;
        if (numCheck > 0) Console.WriteLine("Positive");
        else if (numCheck < 0) Console.WriteLine("Negative");
        else Console.WriteLine("Zero");

        Car myCar = new Car();
        myCar.Drive();
    }
}

// ---------- Support Classes ----------
class Person
{
    private string name;
    public void SetName(string n) => name = n;
    public string GetName() => name;
}

class MyClass
{
    private void Hidden() => Console.WriteLine("Private called");
    public void Show() => Hidden();
}

class Counter
{
    public static int count = 0;
    public Counter() { count++; }
}

class Base
{
    protected void SayHi() => Console.WriteLine("Hi from base");
}

class Derived : Base
{
    public void CallBase() => SayHi();
}

class Car
{
    public void Drive() => Console.WriteLine("Driving...");
}
