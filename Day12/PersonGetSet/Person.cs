using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonGetSet
{
    internal class Person
    {
        public string Name { get; set; }

        public string Email { get; set; }

        // Addresses is a list property that holds a collection of Address objects.
        public List<Address> Addresses { get; set; }
    }
}
