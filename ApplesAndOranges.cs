using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class ApplesAndOranges {

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {

        var m = apples.Length;
        var n = oranges.Length;

        var appleDistances = new int[m];
        for (var i=0; i < m; i++) {
            appleDistances[i] = apples[i] + a;
        }

        var orangeDistances = new int[n];
        for (var i=0; i < n; i++) {
            orangeDistances[i] = oranges[i] + b;
        }

        var applesCount = 0;
        foreach (var distance in appleDistances) {
            if (distance >= s  && distance <= t) 
                applesCount++;
        }

        var orangesCount = 0;
        foreach (var distance in orangeDistances) {
            if (distance >= s && distance <= t) 
                orangesCount++;
        }

        Console.WriteLine(applesCount);
        Console.WriteLine(orangesCount);
    }

    static void Main(string[] args) {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);

        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
        ;

        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
        ;
        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
