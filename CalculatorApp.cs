using System;

public class CalApp
{
    public void CalculatorApp()
    {
        string? response;
        Console.WriteLine("Welcome to a Calculator App");
        do
        {
            
            Console.WriteLine("Please enter your first number: ");
            string? input1 = Console.ReadLine();
            double num1;
            while (!Double.TryParse(input1, out num1))
            {
                Console.WriteLine("invalid input! Please enter a valid number: ");
                input1 = Console.ReadLine();
            }

            Console.WriteLine("Please enter an operation (+,-,*, or /): ");
            string? Op = Console.ReadLine();
            while(Op != "+" && Op != "-" && Op != "*" && Op != "/" )
            {
                Console.WriteLine("Please enter a valid operation (+,-,*, or /): ");
                Op = Console.ReadLine();
            }

            Console.WriteLine("Please enter your second number: ");
            string? input2 = Console.ReadLine();
            double num2;
            while(!Double.TryParse(input2, out num2))
            {
                Console.WriteLine("Invalid input! Please enter a valid number: ");
                input2 = Console.ReadLine();
            }

            double result = 0;
            switch (Op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                default:
                    result = num1 / num2;
                    break;

            }
            Console.WriteLine("The result of " + num1 + " " + Op + " " + num2 + " is " + result);

            Console.WriteLine("Do you can to perform another operation? Yes / No");
            response = Console.ReadLine();
        }while(response.ToUpper() == "YES");
        

    }
}