using System;
using System.Collections.Generic;
namespace AlignOutput;
    class Program
{
    public static void Main(string[] args)
    {
        List<string> names = new List<string> { "Christa", "Sarah","Jonathan", "Sam" };
        Console.WriteLine("Next names have different length");
        foreach (string s in names)
        {
            Console.WriteLine("Name "+ s + " before changing");
        }
        Console.WriteLine();
        List<string> stringsToAlign = new List<string>();
        for (int i = 0; i < names.Count; i++)
        {
            string trimmedName = names[i].Trim();
            stringsToAlign.Add(trimmedName);
        }
        int maxLength = 0;
        foreach (string s in stringsToAlign)
        {
            if (s.Length > maxLength)
            {
                maxLength = s.Length;
            }
        }
        for (int i = 0; i < stringsToAlign.Count; i++)
        {
            stringsToAlign[i] = stringsToAlign[i].PadRight(maxLength + 1);
        }
        Console.WriteLine("Now those names are aligned and have same length");
        foreach (string s in stringsToAlign)
        {
            Console.WriteLine("Name" + s + "After changing");
        }
        Console.WriteLine("Press 'Enter' to over");
        Console.Read();
    }
}
