namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, World!");
            Console.WriteLine("My name is Negar");
            Console.WriteLine("What is your favourite food?");
            Console.ReadLine();
            Console.WriteLine("WOW, it is my favourite food, too!");
            */

            /*
            int firstNumber = 1;
            double secondNumber = 5.7;
            int thirdNumber = 998;
            string firstName = "Bruce";
            string lastName = "Banner";
            char singleLetter = 'd';
            bool isMail = true;
            Console.WriteLine("I am " + firstName + " " + lastName + " and it is " + isMail );
            */


            //-------------------------------------------------------------------------------------------------------

            /*
            Console.Write("Type your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Type your second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write($"The sum of two numbers {firstNumber} and {secondNumber} is: ");
            int sum = firstNumber + secondNumber;
            Console.WriteLine(sum);
            */


            //-------------------------------------------------------------------------------------------------------

            /*
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Welcome to this course, {firstName} {lastName}!");
            */


            //-------------------------------------------------------------------------------------------------------

            /*
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18) {
                Console.WriteLine("Sorry, You are not allowed to drink");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Okay, you are allowed to enter!");
            }
            */

            //-------------------------------------------------------------------------------------------------------

            /*
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case 18:
                    Console.WriteLine("Allowed");
                    break;
                case 17:
                    Console.WriteLine("Not allowed!");
                    break;
                case 19:
                    Console.WriteLine("Allowed!");
                    break;
            }
            */

            //-------------------------------------------------------------------------------------------------------

            /*
            Console.Write("Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int thirdNum = int.Parse(Console.ReadLine());
            int sum = firstNum + secondNum + thirdNum;

            if (sum > 100)
            {
                Console.WriteLine($"The number {sum} is bigger than 100.");
            } else if (sum < 100)
            {
                Console.WriteLine($"The number {sum} is less than 100.");

            }  else {
                Console.WriteLine("The number is exactly 100");
                    }
            */

            //-------------------------------------------------------------------------------------------------------


            /*
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            */

            //-------------------------------------------------------------------------------------------------------

            /*
            int i = 1;

            while (i <=50)
            {
                Console.WriteLine(i);
                i++;
            }
            */

            //-------------------------------------------------------------------------------------------------------

            /*
            int i = 7;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 6);
            */

            //-------------------------------------------------------------------------------------------------------

            /*
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            //-------------------------------------------------------------------------------------------------------


            //  Greeting("David");
            //  Add(5, 6);

            /*
            int[] myArray = new int[4];
            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;
       
            Console.WriteLine(myArray[1]);

            string[] names = { "ali", "john", "moh", "ben", "allen"};
            Console.WriteLine(names.Length);
            Console.WriteLine(names[0]);

            int[] values = { 1, 2, 3, 4, 5, 6, 7};

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
            */

        }

        /*
        static void Greeting(string text)
        {
            Console.WriteLine($"Greeting! {text}");
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        */


    }
}
