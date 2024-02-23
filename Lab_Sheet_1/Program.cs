using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file2.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 : Caculate the area of a rectangle
            CalculateArea();
            //Task 2 : Check if the numbers are odd or even
            OddOrEven();
            //Task3 : Calculate Sum of numbers until N
            CalculateSum();
            //Task 4 : Print the Fibonacci Series
            FibonacciSeries();
            //Task 5 : Display multiplication table
            DispalyMultiplicationTable();
            // Task 6: Determine student grade
            DetermineStudentGrade();

            // Task 7: Simulate basic ATM machine
            ATMMachine();




            void CalculateArea()
            {
                Console.WriteLine("enter the length ");
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the width");
                int w = int.Parse(Console.ReadLine());
                int area = l * w;
                Console.WriteLine("the area is " + area);
                Console.ReadLine();
            }
            void OddOrEven()
            {
                Console.WriteLine("enter 10 numbers");
                for (int i = 0; i <= 10; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        Console.WriteLine(num + " is even");


                    }
                    else
                    {
                        Console.WriteLine(num + " is odd");
                    }
                }

            }
            void CalculateSum()
            {
                Console.WriteLine("enter a number");
                int value = int.Parse(Console.ReadLine());
                int sum = 0;
                int temp = value;
                for (int i = 0; i <= temp; i++)
                {
                    sum += value;
                    value--;
                }
                Console.WriteLine("the result is " + sum);

            }
            void FibonacciSeries()
            {
                Console.WriteLine("enter number ");
                int n = int.Parse(Console.ReadLine());
                int firstTerm = 0, secondTerm = 1, nextTerm;
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{firstTerm} ");

                    nextTerm = firstTerm + secondTerm;
                    firstTerm = secondTerm;
                    secondTerm = nextTerm;
                }
                Console.WriteLine("\n");


            }
            void DispalyMultiplicationTable()
            {
                Console.WriteLine("enter a number");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = 1;
                for (int i = 0; i < 10; i++)
                {
                    n2 *= n1;
                    Console.WriteLine(n2);

                }

            }
            void DetermineStudentGrade()
            {
                Console.WriteLine("Enter student's name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter exam marks:");
                int marks = int.Parse(Console.ReadLine());

                if (marks < 0 || marks > 100)
                {
                    Console.WriteLine("ERROR: Marks should be between 0 and 100.");
                    return;
                }

                char grade;

                if (marks >= 75)
                    grade = 'A';
                else if (marks >= 60)
                    grade = 'B';
                else if (marks >= 50)
                    grade = 'C';
                else if (marks >= 40)
                    grade = 'D';
                else
                    grade = 'F';

                Console.WriteLine($"Student Name: {name}, Grade: {grade}");
            }
            void ATMMachine()
            {
                int balance = 1000;

                while (true)
                {
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Deposit Money");
                    Console.WriteLine("3. Withdraw Money");
                    Console.WriteLine("4. Exit");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Your balance is: {balance}");
                            break;
                        case 2:
                            Console.WriteLine("Enter amount to deposit:");
                            int deposit = int.Parse(Console.ReadLine());
                            balance += deposit;
                            Console.WriteLine($"Deposited {deposit}. Your new balance is: {balance}");
                            break;
                        case 3:
                            Console.WriteLine("Enter amount to withdraw:");
                            int withdrawal = int.Parse(Console.ReadLine());
                            if (withdrawal > balance)
                                Console.WriteLine("Insufficient balance.");
                            else
                            {
                                balance -= withdrawal;
                                Console.WriteLine($"Withdrawn {withdrawal}. Your new balance is: {balance}");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
            }










        }
    }
}
