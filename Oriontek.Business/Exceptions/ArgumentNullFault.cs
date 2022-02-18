using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Business.Exceptions
{
    public class ArgumentNullFault : Exception
    {
        public ArgumentNullFault()
        {
        }

        public ArgumentNullFault(string message)
            : base(message)
        {
        }

        public ArgumentNullFault(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
