﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class RandomExtensions
    {
        public static void Shuffle(Random rand, int[] array)
        {
            var n = array.Length;
            while (n > 1)
            {
                int k = rand.Next(n--);
                (array[k], array[n]) = (array[n], array[k]);

            }
        }

        public static void Shuffle(Random rand, List<int> values)
        {
            var n = values.Count;
            while (n > 1)
            {
                int k = rand.Next(n--);
                (values[k], values[n]) = (values[n], values[k]);

            }
        }

        public static void Shuffle<T>(Random rand, List<T> list)
        {
            var n = list.Count;
            while (n > 1)
            {
                int k = rand.Next(n--);
                (list[k], list[n]) = (list[n], list[k]);

            }
        }
    }
}

