using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Business.Exceptions
{
    [Serializable]
    public class SecurityCustomException : ApplicationException
    {
        public SecurityCustomException()
        {
        }

        public SecurityCustomException(string message)
            : base(message)
        {
        }

        public SecurityCustomException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
