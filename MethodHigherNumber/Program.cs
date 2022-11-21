using MethodHigherNumber;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DisplayQuestions();
        }
        static void displayMessage()
        {
            Console.WriteLine("Welcome to the 2 names, combined ages program!");
            Console.WriteLine();
        }

        // This string method will capture the value from the user and return that data when specified.
        static string getUserQuestion (string userQuestion)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(userQuestion);
            string UserInputName = Console.ReadLine();
            return UserInputName;
        }
        static void DisplayQuestions ()
        {
            try
            {
                // displays the method welcoming the user
                displayMessage();
                // capturing the string value for the string getUserQuestion method
                string firstName = getUserQuestion("Enter the first name: ");
                string firstAge = getUserQuestion("Please enter the first age: ");
                Console.WriteLine();
                int ageOne = int.Parse(firstAge);

                string secondName = getUserQuestion("Enter the second name: ");
                string secondAge = getUserQuestion("Please enter the second age: ");
                int ageTwo = int.Parse(secondAge);


                int combinedAge = (ageOne + ageTwo);

                Console.Clear();
                Console.WriteLine($"The names entered were {firstName} and {secondName}");
                Console.WriteLine($"The age values you entered were {ageOne} years old and {ageTwo} years old");
                Console.WriteLine($"Combined this adds up to {combinedAge}");
            }
            catch (Exception error)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine (error.Message);
            }
        }
    }
}