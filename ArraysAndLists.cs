using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals
{
    class ArraysAndLists
    {
        // 1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        public void Exercise1()
        {
            var names = new List<string>();
            while(true)
            {
                Console.WriteLine("Name please: [press <Enter> to exit] ");
                var input = Console.ReadLine();
                if(String.IsNullOrWhiteSpace(input))
                    break;

                names.Add(input);
            }
            
            if(names.Count == 1)            
                Console.WriteLine("{0} likes your post", names[0]);
            else if(names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if(names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
        }

        /* 2 - Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.*/
        public void Exercise2()
        {
            Console.Write("Enter your Name: ");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
                return;

            //var name = input.ToCharArray();
            //Array.Reverse(name);

            var name = new char[input.Length];
            for(var i=0; i < input.Length; i++)
            {
                name[input.Length - 1 - i] = input[i];
            }
            var reversed = new String(name);
            Console.WriteLine("Reversed Name: " + reversed);
        }

        //3 - Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        public void Exercise3()
        {
            var numbers = new List<int>();

            Console.WriteLine("Enter 5 unique numbers: ");
            while (true)
            {             
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("Sorry! Duplicate Number, please enter a new number");
                    continue;
                }
                numbers.Add(input);
                if (numbers.Count == 5)
                    break;             
            }

            numbers.Sort();
            
            Console.WriteLine("Sorted List: ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        //4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.The list of numbers may include duplicates. Display the unique numbers that the user has entered.
        public void Exercise4()
        {
            var numbers = new List<int>();
            while(true)
            {
                Console.WriteLine("Enter a number or type 'Quit' to quit");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
               
                numbers.Add(Convert.ToInt32(input));
            }

            var uniqueList = new List<int>();
            Console.WriteLine("You entered following unique numbers: ");
            foreach (var number in numbers)
            {
                if (!uniqueList.Contains(number))
                {
                    uniqueList.Add(number);
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }

        //5- Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
        public void Exercise5()
        {
            String[] elements;           
            while (true)
            {
                Console.Write("Enter five or more comma separated numbers: ");
                var input = Console.ReadLine();
                if(!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');

                    if (elements.Length >= 5)
                    {
                        break;
                    }
                        
                }
                Console.WriteLine("Invalid List");              
            }

            var numbersArray = new int[elements.Length];
            for(var i=0; i<elements.Length; i++)
            {
                numbersArray[i] = Convert.ToInt32(elements[i]);
                
            }
            Array.Sort(numbersArray);

            Console.Write("3 smallest numbers in an array: {0}, {1}, {2}", numbersArray[0], numbersArray[1], numbersArray[2]);
            Console.WriteLine();
        }
    }
}
