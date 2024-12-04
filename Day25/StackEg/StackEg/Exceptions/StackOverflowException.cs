using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackEg.Exceptions
{
    public class StackOverflowException : Exception
    {
        public StackOverflowException() : base("Stack overflow") { }
        public StackOverflowException(string message) : base(message) { }
    }
}
