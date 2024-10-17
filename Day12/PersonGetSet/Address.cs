using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonGetSet
{
    internal class Address
    {
        // AddressType, AddressLine1, AddressLine2, and PinCode are properties
        public string AddressType { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int PinCode { get; set; }
    }
}
