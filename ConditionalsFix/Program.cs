using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsFix
{
    class Program
    {
        static void Main(string[] args)
        {
                //        Console.WriteLine("Enter your age");
                //    }
                //    int age = int.Parse(Console.ReadLine());

                //            if(true);
                //            { 
                //            Console.WriteLine("Sorry you are too young you need a parent present");


                //        /*Write a console application to ask the user for two integers. 
                //        Check and see if the two integers are equal to each other. 
                //        If they are, inform the the user that the numbers are equal, else inform the user
                //        that the numbers are not equal*/


                //Console.WriteLine("Enter your perentage");
                //int grade = int.Parse(Console.ReadLine());
                //if (grade >= 90 && grade <= 100)

                //{
                //    Console.WriteLine("You got an A!!");
                //}
                //else if (grade >= 80 && grade <= 89)
                //{
                //    Console.WriteLine("You got a B!! not bad");
                //}


                //ask the user for the total bill
                //ask  the user for the number of people
                //Console.WriteLine("Please enter your total bill");
                //double totalBill = double.Parse(Console.ReadLine());

                //Console.WriteLine("How many people were at dinner");
                //int numberOfPeople = int.Parse(Console.ReadLine());

                //if the total bill is over 50 10 % discount
                //double discount = 0.0;
                //if (totalBill > 50.0d)
                //{
                //    discount = 1.10;
                //    totalBill = totalBill / discount;
                //}
                //else
                //{
                //    discount = 1.05;
                //    totalBill = totalBill / discount;

                //}

                //else the total bill gets a 5 % disount

                //inform the user of the new total and how muh each person pays
                //double perPerson = totalBill / numberOfPeople;
                //Console.WriteLine("Thank you for dining with us Your new total is " + totalBill +
                //    "Each person will pay " + perPerson);

                ////like if/else, switch ase also controls the flow
                //int pointsEarned = 3;
                //swith(pointsEarned
                //    {
                //        case 1;
                //    Console.WriteLine("Needs Pratice");
                //    break;

                //}

                //what is the age
                Console.WriteLine("Please enter your age");
                int age = int.Parse(Console.ReadLine());

                //different categories


                //if (age >= 0 && age <= 2)
                //{
                //    Console.WriteLine("Still in Momma's Arms");
                //}
                //else if (age >= 2 && age <= 4)
                //{
                //    Console.WriteLine("Preschool Maniac");
                //}
                //if (age >= 4 && age <= 11);
                //{
                //    Console.WriteLine("Elementary School");
                //}       
                //if (age >= )

                Console.WriteLine("Please enter a number");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine(number + " is even");
                }
                else
                {
                    Console.WriteLine(number + " is odd");
                }
            }
    }
}
