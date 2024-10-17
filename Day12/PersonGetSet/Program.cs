using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonGetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // An instance of Person (named p1) is created.
            var p1 = new Person();
            // The Name and Email properties are set for this person.
            p1.Name = "Mr X";
            p1.Email = "jocj@dkmc.com";
            var address = new List<Address>
            {
                // Each address object includes the address type, address lines, and pincode.
                new Address { AddressType = "Home", AddressLine1 = "kochi", AddressLine2 = " Kerala", PinCode = 655622 },
                new Address { AddressType = "work", AddressLine1 = "kannur", AddressLine2 = " Kerala", PinCode = 655532 },
            };
            // List of addresses is assigned to the Addresses property of the person.
            p1.Addresses = address;
        }
    }
}
