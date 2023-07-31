using System;
namespace Assignment19

//part-1
{
    public delegate int ArithmeticOperation(int n1, int n2);
    internal class Program
    {
        static class Calculator
        {
            public static int Add(int n1, int n2)
            {
                return n1 + n2;
            }

            public static int Subtract(int n1, int n2)
            {
                return n1 - n2;
            }

            public static int Multiply(int n1, int n2)
            {
                return n1 * n2;
            }

            public static int Divide(int n1, int n2)
            {
                if (n2 != 0)
                    return n1 / n2;
                else
                    throw new ArgumentException("Error!!!!!Can't divide by zero");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                ArithmeticOperation addDel = new ArithmeticOperation(Calculator.Add);
                ArithmeticOperation subDel = new ArithmeticOperation(Calculator.Subtract);
                ArithmeticOperation mulDel = new ArithmeticOperation(Calculator.Multiply);
                ArithmeticOperation divDel = new ArithmeticOperation(Calculator.Divide);
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose an arithmetic operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                int choice = int.Parse(Console.ReadLine());

                int result = 0;
            again:
                switch (choice)
                {
                    case 1:
                        result = addDel(num1, num2);
                        Console.WriteLine($"Addition of {num1} and {num2} is : {result}");
                        break;

                    case 2:
                        result = subDel(num1, num2);
                        Console.WriteLine($"subtraction of {num1} and {num2} is : {result}");
                        break;

                    case 3:
                        result = mulDel(num1, num2);
                        Console.WriteLine($"Mltiplication of {num1} and {num2} is : {result}");
                        break;

                    case 4:
                        try
                        {
                            result = divDel(num1, num2);
                            Console.WriteLine($"Division of {num1} and {num2} is : {result}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        goto again;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { 
            Console.ReadKey();
             }
        }

    }
}


//using System;
//namespace Assignment19
////part2
//{
//    public delegate T Operation<T>(T a, T b);
//    class Program
//    {
//        static T Add<T>(T a, T b) => (dynamic)a + (dynamic)b;
//        static T Subtract<T>(T a, T b) => (dynamic)a - (dynamic)b;
//        static T Multiply<T>(T a, T b) => (dynamic)a * (dynamic)b;
//        static T Divide<T>(T a, T b) => (dynamic)a / (dynamic)b;
//        static void PerformOperation<T>(T a, T b, Operation<T> operation)
//        {
//            T result = operation(a, b);
//            Console.WriteLine($"Result: {result}");
//        }
//        static void Main(string[] args)
//        {
//            try
//            {
//                Console.WriteLine("Enter two values of the same data type:");
//                Console.Write("Value 1: ");
//                string input1 = Console.ReadLine();
//                Console.Write("Value 2: ");
//                string input2 = Console.ReadLine();

//                Console.WriteLine("Choose an operation:");
//                Console.WriteLine("1. Addition");
//                Console.WriteLine("2. Subtraction");
//                Console.WriteLine("3. Multiplication");
//                Console.WriteLine("4. Division");

//                int choice = int.Parse(Console.ReadLine());
//            again:
//                switch (choice)
//                {
//                    case 1:
//                        PerformOperation(int.Parse(input1), int.Parse(input2), Add);
//                        break;
//                    case 2:
//                        PerformOperation(int.Parse(input1), int.Parse(input2), Subtract);
//                        break;
//                    case 3:
//                        PerformOperation(int.Parse(input1), int.Parse(input2), Multiply);
//                        break;
//                    case 4:
//                        PerformOperation(int.Parse(input1), int.Parse(input2), Divide);
//                        break;
//                    default:
//                        Console.WriteLine("Invalid choice!");
//                        goto again;
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//            finally
//            {
//                Console.ReadKey();
//            }
//        }
//    }
//}
