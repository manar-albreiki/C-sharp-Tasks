using System.Drawing;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
//convert from string to int ----readline is string 
            Console.WriteLine("please enter first number ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter second number ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");

            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");



        }
    }
}
