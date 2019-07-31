using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals
{
    class DecimalTimeSpan
    {     
        public static void CalculateDecimalTimeSpan()
        {
            Console.WriteLine("Enter Year and Month separated by space");
            var input = (Console.ReadLine());
            var monthYear = input.Split(' ');

            var inputYear = Convert.ToInt32(monthYear[0]);
            var inputMonth = Convert.ToInt32(monthYear[1]);

            var inputMonths = 11 - inputMonth;

            var now = DateTime.Now;
            var nowMonths = now.Month - 1;

            var betweenMonths =(now.Year - inputYear - 1) * 12;          
            var totalMonths = betweenMonths +  inputMonths + nowMonths;            

            float decimalMonths = (float) (totalMonths * 10) / 12;
            Console.WriteLine("DecimalMonths: " + Math.Round(decimalMonths, 2));         
        }
    }
    
}
