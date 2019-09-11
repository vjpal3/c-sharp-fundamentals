using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals
{
    class WorkingWithText
    {
        //1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
        public static bool Exercise1()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen");
            var input = Console.ReadLine();    
            var strArray = input.Split('-');
            var list = new List<int>();

            foreach (var item in strArray)
            {
                list.Add(Convert.ToInt32(item));
            }
            return IsConsecutiveList(list);
        }

        public static bool IsConsecutiveList(List<int> list)
        {
            var numbers = new int[list.Count];
            //Copy list into array. Calling Sort() directly on list impact the argument of this method. Caller of this method only expects a true/false answer as a result of this call. So, this method should not have a side-effect.
            list.CopyTo(numbers);
            Array.Sort(numbers);

            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] - numbers[i + 1] != -1)
                    return false;
            }
            return true;
        }

        //2- Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.If so, display "Duplicate" on the console.
        public static bool Exercise2()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
                return false;

            var numbers = new List<int>();
            var StrArray = input.Split('-');
            foreach (var item in StrArray)            
                numbers.Add(Convert.ToInt32(item));

            return containsDuplicates(numbers);
            
            //numbers.Sort();

            //for (var i = 0; i < numbers.Count-1; i++)
            //{
            //    if (numbers[i] == numbers[i + 1])
            //        return "Duplicate"; 
            //}
            //return "Not Duplicate";
        }

        public static bool containsDuplicates(List<int> list)
        {
            var uniqes = new List<int>();
            foreach(var number in list)
            {
                if (!uniqes.Contains(number))
                    uniqes.Add(number);
                else
                    return true;
            }
            return false;
        }

        //3- Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
        public static bool Exercise3()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format(e.g. 19:00)");
            var input = Console.ReadLine();
            return IsValidTime(input);
        }

        public static bool IsValidTime(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return false;
            var components = input.Split(':');
            if (components.Length != 2)
                return false;
            try
            {
                int hour = Convert.ToInt32(components[0]);
                int minute = Convert.ToInt32(components[1]);

                if ((hour >= 0 && hour <= 23) && (minute >= 0 && minute <= 59))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //4- Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name with PascalCase.For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input.So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
        public static string Exercise4()
        {
            Console.WriteLine("Enter a few words separated by a space");
            var input = Console.ReadLine();
            return FormPascalCase(input);
        }

        public static string FormPascalCase(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return "Error";

            var words = input.Split(' ');
            var builder = new StringBuilder();
            foreach (var word in words)            
                builder.Append(Char.ToUpper(word[0])).Append(word.Substring(1).ToLower());

            return builder.ToString();
        }

        //5- Write a program and ask the user to enter an English word.Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.
        public static int Exercise5()
        {
            Console.WriteLine("Please Enter an English word");
            //Note the ToLower() here.This is used to count for both A and a.
            var input = Console.ReadLine().ToLower();
            if (String.IsNullOrWhiteSpace(input))
                return 0;
            return CountVowels(input);  
        }

        public static int CountVowels(string input)
        {
            var vowels = "aeiou";
            var vowelCount = 0;
            foreach (var ch in input)
            {
                if (vowels.IndexOf(ch) != -1)
                    vowelCount++;
            }
            return vowelCount;
        }
    }
}
