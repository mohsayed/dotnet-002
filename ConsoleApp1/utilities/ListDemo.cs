using System;

namespace ConsoleApp1.utilities;

public static class ListDemo
{
    public static void ListyDemo01()
    {

        List<DateOnly> Vacations = [
            new(2026,11,30),
            new(2026,9,17),
            new(2026,5,8)
            ];

        foreach (var date in Vacations)
        {
            Console.WriteLine(date.ToLongDateString());

        }
        Console.WriteLine("done");
    }

    public static void ListDemo02()
    {
        var colors = new List<string>();
        colors.Add("Red");
        colors.Add("Espresso");
        colors.Add("White");
        colors.Add("Navy");
        colors.Remove("white");
        colors.Insert(1, "brown");

        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }

    }

    public static void ListDemo03()
    {
        var colors = new List<string> { "Red", "White", "Black", "yellow" };

        Console.WriteLine(colors[1]);
        var x = colors.IndexOf("Red");
        Console.WriteLine(x);
        Console.WriteLine();

        for (int i = 0; i < colors.Count; i++)
        {
            Console.WriteLine($"color {i + 1} is {colors[i]}");
        }



    }

}
