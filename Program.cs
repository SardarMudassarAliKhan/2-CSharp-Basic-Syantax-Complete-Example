class Program
{
    static void Main(string[] args)
    {
        // This is a basic C# program demonstrating syntax

        // Declaring and initializing variables
        int number = 10;
        string message = "Hello, world!";

        // Outputting variables to the console
        Console.WriteLine(message);
        Console.WriteLine("The number is: " + number);

        // Using conditional statements
        if(number > 5)
        {
            Console.WriteLine("The number is greater than 5.");
        }
        else
        {
            Console.WriteLine("The number is less than or equal to 5.");
        }

        // Using a loop
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Loop iteration: " + i);
        }

        // Using a method
        int result = Add(5, 3);
        Console.WriteLine("The result of addition is: " + result);
    }

    // Defining a method
    static int Add(int a, int b)
    {
        return a + b;
    }
}
