using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals
{
    class ReadMoreUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            Console.WriteLine(text);
            if (text.Length < maxLength)
                return text;

            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                totalCharacters += word.Length + 1;
                summaryWords.Add(word);
                if (totalCharacters >= maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + " ...Read More";
        }
    }
}
