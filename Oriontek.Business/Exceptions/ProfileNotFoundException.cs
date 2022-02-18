using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Business.Exceptions
{
    [Serializable]
    public class ProfileNotFoundException : ApplicationException
    {
        public ProfileNotFoundException()
        {
        }

        public ProfileNotFoundException(string message)
            : base(message)
        {
        }

        public ProfileNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
