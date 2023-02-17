using System.Security.Cryptography.X509Certificates;

namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. greetings

            string name;
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            int currentYear = DateTime.Now.Year;

            int birthYear = currentYear - age;

            Console.WriteLine($"Hello, your name is {name} and you are {age} years old, born in {birthYear}");


            // 2. adder

            Console.WriteLine();

            Console.WriteLine("Please enter three numbers: ");
            Console.WriteLine();

            Console.WriteLine("Enter first number");
            int intOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int intTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int intThree = Convert.ToInt32(Console.ReadLine());

            int total = intOne + intTwo + intThree;

            Console.WriteLine("Your total of the 3 numbers is: " + total);


            //find hypotenuse
            Console.WriteLine("To find the hypotenuse enter two legs of a right triangle");

            Console.WriteLine("Enter leg one: ");
            int legOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter leg two: ");
            int legTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

        }
   



        public static double Sqrt(double leg1, double leg2)
        {
            return leg1 + leg2;
        }
    }



}