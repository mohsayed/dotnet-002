using System;

namespace ConsoleApp1.utilities;

public static class DictionaryDemo
{
    public static void show01()
    {
        var states = new Dictionary<string, string>();
        states.Add("CA", "California");
        states.Add("WA", "Washington");
        states.Add("NY", "New York");

        Console.WriteLine("\n show1 \n");
        foreach (var state in states)
        {
            Console.WriteLine($"{state.Key}: {state.Value}");
        }
    }
    public static void show02()
    {
        var states = new Dictionary<string, string>()
            {
                {"CA", "California" },
                {"WA", "Washington"},
                {"NY", "New York" },
            };

        Console.WriteLine("\n show2 \n");

        foreach (var state in states)
        {
            Console.WriteLine($"{state.Key}: {state.Value}");
        }
    }

    public static void show03()
    {
        // foreach (var element in vendors)
        // {
        //     var vendor = element.Value;
        //     var key = element.Key;
        //     Console.WriteLine($"Key: {key} Value: {vendor}");
        // }
    }

    public static void show04 ()
    {
        var dict = VendorRepository.GetVendorsDict();
        foreach (var item in dict)
        {
            Console.WriteLine($"Code: {item.Key}");
            Vendor vendor = item.Value;
            Console.WriteLine(vendor);
            Console.WriteLine();
        }
    }

}
