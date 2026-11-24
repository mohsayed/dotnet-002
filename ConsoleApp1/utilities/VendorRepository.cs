using System;

namespace ConsoleApp1.utilities;

public static class VendorRepository
{
    public static List<Vendor> GetVendorsList()
    {
        var vendors = new List<Vendor>();

        vendors.Add(new Vendor()
        { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
        vendors.Add(new Vendor()
        { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" });
        return vendors;
    }

    public static Dictionary<int, Vendor> GetVendorsDict()
    {
        var vendors = new Dictionary<int, Vendor>()
            {
                { 5, new Vendor
                    { VendorId = 5, CompanyName = "ABC Corp", Email = "abc@abc.com" } },
                { 8, new Vendor()
                    { VendorId = 8, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" } },
                {12, new Vendor
                     { VendorId = 12, CompanyName = "Textile Holding", Email = "info@ctihc.com"}}
            };
        return vendors;
    }

}
