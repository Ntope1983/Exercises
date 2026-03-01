// This program displays a simple menu to the user,
// allows selecting operations (addition or multiplication of two numbers),
// and continues running until the user chooses to exit.
// It includes input validation using TryParse.
class MyFirstProgram
{
    static void Main(string[] args)
    {

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
}