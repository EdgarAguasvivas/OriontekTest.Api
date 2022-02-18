using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Business.Exceptions
{
    [Serializable]
    public class AuthorizationValidationException : ApplicationException
    {
        public AuthorizationValidationException()
        {
        }

        public AuthorizationValidationException(string message)
            : base(message)
        {
        }

        public AuthorizationValidationException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
