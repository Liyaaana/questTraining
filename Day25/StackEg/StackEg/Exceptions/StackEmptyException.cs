using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackEg.Exceptions
{
    internal class StackEmptyException: Exception
    {
        public StackEmptyException(): base("Stack empty"){}
        public StackEmptyException(string message): base(message){}
    }
}
