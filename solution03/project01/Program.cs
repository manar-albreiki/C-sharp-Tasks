using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            //Console.WriteLine("please enter an integer number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num > 0)
            //{
            //    Console.WriteLine("positive");
            //}
            //else if (num < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("zero");
            //}


            //task 2
            //Console.WriteLine("please enter an integer number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("even number");
            //}
            //else
            //{
            //    Console.WriteLine("odd number");
            //}


            //task 3
            //Console.WriteLine("please enter a student score (0-100)");
            //int score = Convert.ToInt32(Console.ReadLine());

            //if (score >= 90 && score == 100)
            //{
            //    Console.WriteLine("Excellent");
            //}
            //else if (score >= 75 && score <= 89)
            //{
            //    Console.WriteLine("Very Good");
            //}
            //else if (score >= 60 && score <= 74)
            //{
            //    Console.WriteLine("Good");
            //}
            //else if (score >= 50 && score <= 59)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else if (score >= 0 && score < 50)
            //{
            //    Console.WriteLine("Fail");
            //}
            //else
            //{
            //    Console.WriteLine("enter valid score");
            //}


            //task 4
            //Console.WriteLine("please enter the email");
            //string email = Console.ReadLine();
            //Console.WriteLine("please enter the password");
            //int password = Convert.ToInt32(Console.ReadLine());
            //if (email== "admin" && password == 1234)
            //{
            //    Console.WriteLine("Login Successful");

            //}
            //else
            //{
            //    Console.WriteLine("Invalid Username or Password");
            //}

            // task 5
            int balance = 1000;
           
            Console.WriteLine("please enter the withdrawal amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            int remaining = balance - amount;

            if (amount <= 0)
            {
                Console.WriteLine("Invalid Amount");
            }
            else if (amount >= balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else if (amount <balance || amount == balance)
            {
                Console.WriteLine("Withdrawal Successful");
                Console.WriteLine("the remaining balance = "+ remaining);
            }


        }
    }
}
