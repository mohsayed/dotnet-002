using System;

namespace ConsoleApp1.utilities;

public class Vendor
{
    public int VendorId { get; set; }
    public string? CompanyName { get; set; }
    public string? Email { get; set; }

    public override string ToString()
    {
        var print = $"Id: {this.VendorId} -- Company: {this.CompanyName} -- Email: {this.Email}";
        
        return print;
    }
}
