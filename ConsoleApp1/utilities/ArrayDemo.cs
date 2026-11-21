using System;

namespace ConsoleApp1.utilities;

public static class ArrayDemo
{
    public static void ArrayDemo01()
    {
        DateOnly d1 = new(2026, 11, 15);

        Console.WriteLine(d1);

        DateOnly[] Vacations = [
            new(2026,11,30),
            new(2026,9,17),
            new(2026,5,8)
            ];

        foreach (var date in Vacations)
        {
            Console.WriteLine(date);

        }
        Console.WriteLine("done");
    }

    public static void ArrayDemo02()
    {
        DateOnly[] holidayDates = DatesRepository.Instance.HolidayDates;
        Console.WriteLine("Holidays when the library is closed:");
        foreach (DateOnly date in holidayDates)
        {
            Console.WriteLine(date.ToLongDateString());
        }
    }
    public static void ArrayDemo03()
    {
        var colors = new string[4];
        colors[0] = "Red";
        colors[1] = "Espresso";
        colors[2] = "White";
        colors[3] = "Navy";

        var colors2 = new string[4] {"col1","col2","col3","col4"};
        string[] colors3 = ["red","blue"];

        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }

        Console.WriteLine(colors3[1]);

        Console.WriteLine();

        for (int i = 0; i < colors2.Length; i++)
        {
            Console.WriteLine(colors2[i]);
            Console.WriteLine($"color {i+1} is {colors2[i]}");
        }
        
        

    }
}


