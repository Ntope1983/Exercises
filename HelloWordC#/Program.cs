// This program displays a simple menu to the user,
// allows selecting operations (addition or multiplication of two numbers),
// and continues running until the user chooses to exit.
// It includes input validation using TryParse.
class MyFirstProgram
{
    static void Main(string[] args)
    {
        //Exercise1();
        Exercise2();
        //Exercise3();

    }
    static void Exercise1()
    {
        // This program displays a simple menu to the user,
        // allows selecting operations (addition or multiplication of two numbers),
        // and continues running until the user chooses to exit.
        // It includes input validation using TryParse.
        Console.WriteLine("Please give your Name");
        string name = Console.ReadLine();
        Console.WriteLine("Please give your age");
        string age = Console.ReadLine();
        int ageValue;
        bool success = int.TryParse(age, out ageValue);
        while (!success)
        {
            Console.WriteLine("Please give again a valid age");
            age = Console.ReadLine();
            success = int.TryParse(age, out ageValue);
        }
        int futureAge = ageValue + 10;
        Console.WriteLine("Hello " + name + " you will be  " + futureAge + " years old after 10 years");
    }

    static void Exercise2()
    {
        string menu = "Please select an operation:\n" +
                      "1. Add two numbers\n" +
                      "2. Multiply two numbers\n" +
                      "3. Exit";
        Console.WriteLine(menu);
        string choice = Console.ReadLine();
        int menuValue;
        bool success = int.TryParse(choice, out menuValue) & (menuValue == 1 | menuValue == 2 | menuValue == 3);

        while (!success)
        {
            Console.WriteLine("Please give again a valid age");
            choice = Console.ReadLine();
            success = int.TryParse(choice, out menuValue);
        }
    }

    static void Exercise3()
    {
        // Κώδικας άσκησης 3
    }
}