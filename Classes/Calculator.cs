using System;

namespace CalculatR.Classes
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }

        public void GetInputs()
        {
            Console.WriteLine("Type 1st number: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation(+,-,/,*,%): ");
            Operation = Console.ReadLine();
            Console.WriteLine("Type 2nd number: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
        }

        public bool IsFirstNumberPositive()
        {
            return FirstNumber >= 0;
        }

        public void CompareInputs()
        {
            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine($"1st number is greater than 2nd number!");
            }
            else if (FirstNumber == SecondNumber)
            {
                Console.WriteLine($"1st number is equal to 2nd number!");
            }
            else
            {
                Console.WriteLine($"1st number is less than 2nd number!");
            }
        }

        public string Calculate()
        {
            return Operation switch
            {
                "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
                _ => "Operation Not Found!"
            };
        }

        public void PrintEvenNumbers()
        {
            Console.WriteLine("Printing even numbers till first input...");
            int counter = 2;
            while (counter < FirstNumber)
            {
                Console.WriteLine(counter);
                counter += 2;
            }
        }

        public void PrintMultiplicationTable()
        {
            for (int iterator = 1; iterator <= 10; iterator++)
            {
                for (int innerIterator = 1; innerIterator <= 10; innerIterator++)
                {
                    Console.WriteLine($"{iterator} x {innerIterator} = {iterator * innerIterator}");
                }

                Console.WriteLine("\n");
            }
        }
    }
}