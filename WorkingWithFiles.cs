using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsharpFundamentals
{
    class WorkingWithFiles
    {
       // 1- Write a program that reads a text file and displays the number of words.

        public static int CountWords(string filePath)
        {
            int wordCount = 0;

            if(File.Exists(filePath))
            {
                var contents = File.ReadAllText(filePath);
                var lines = contents.Split('\n');
                foreach(var line in lines)
                {
                    foreach (var word in line.Split(' '))
                    {
                        wordCount++;
                    }
                }
                return wordCount;
            }

            return 0;

        }
    }
}
