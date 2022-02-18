using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Business.Exceptions
{
    [Serializable]
    public class HttpResponseException : ApplicationException
    {
        public HttpResponseException()
        {
        }

        public HttpResponseException(string message)
            : base(message)
        {
        }

        public HttpResponseException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
