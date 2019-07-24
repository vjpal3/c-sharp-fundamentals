using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.

            var count = 0;
            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100", count);

            /*2 - Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.*/

            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number or type 'ok' to exit: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all Numbers is: {0}", sum);

            //3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            Console.WriteLine("Enter a Number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var fact = 1;
            for (var i = 1; i <= input; i++)
                fact *= i;

            //Console.WriteLine("{0}! = {1}", input, fact);

            /*4- Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the number.If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)*/

            var random = new random().next(1, 10);
            var guesses = 4;
            console.writeline("the secret number is: " + random);
            while (guesses >= 1)
            {
                console.write("guess a number between 1 and 10: ");
                var input = convert.toint32(console.readline());
                guesses--;
                if (input == random)
                {
                    console.writeline("you guessed correctly!");
                    return;
                }
            }
            console.writeline("sorry! none of the guesses were correct");

            //5 - Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Enter a series of numbers separated by comma: ");
            var inputArray = Console.ReadLine().Split(',');
            var numbers = Array.ConvertAll(inputArray, int.Parse);
            Console.WriteLine("The max-value in the array: {0}", numbers.Max());

        }
    }
}
