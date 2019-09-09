using System;

namespace CsharpFundamentals.StringAndStringBuilder
{
    class WorkingWithStrings
    {
        public static void StringMethods()
        {
            var input = "  Vrishali Pal ";
            var fullname = input.Trim();
            Console.WriteLine("Trim: '{0}'", fullname);
            //Strings are immutable. These methods return new string, so the result can be chained together. 
            Console.WriteLine("ToUpper: '{0}'", fullname.ToUpper());

            var index = fullname.IndexOf(' ');
            var firstName = fullname.Substring(0, index);
            var lastName = fullname.Substring(index + 1);
            Console.WriteLine("First name: {0}, Last name: {1}", firstName, lastName);

            var names = fullname.Split(' ');
            Console.WriteLine("First name: {0}, Last name: {1}", names[0], names[1]);

            Console.WriteLine(fullname.Replace("Vrishali", "Vrishali J")); 

            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid String");

            var str = "1234";
            int number = Convert.ToInt32(str);
            Console.WriteLine("Number: " + number);

            var price = 3478.91f;
            Console.WriteLine(price.ToString("C")); // $3,478.91
            Console.WriteLine(price.ToString("C0")); // $3,479
            Console.WriteLine(price.ToString("F3")); // 3478.910
        }
    }
}
