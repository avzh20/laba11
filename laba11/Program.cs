using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string line = File.ReadAllText("Inlet.in");
        string[] numbers = line.Split(' ');
        List<int> list = new List<int>();
        int previousElement = int.MinValue;
        foreach (string number in numbers)
        {
            int element = int.Parse(number);
            if (element != previousElement)
            {
                list.Add(element);
                previousElement = element;
            }
        }
        File.WriteAllLines("Outlet.out", list.Select(x => x.ToString()));
        Console.WriteLine("Результат записан в файл Outlet.out.");
    }
}
