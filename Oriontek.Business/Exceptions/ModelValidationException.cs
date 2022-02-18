using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Business.Exceptions
{
    [DataContract]
    public class ModelValidationException : Exception
    {
        private List<string> _Errors;

#pragma warning disable CS0114 // Member hides inherited member; missing override keyword

        public string Message
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        { get; set; }

#pragma warning disable RCS1085 // Use auto-implemented property.

        public List<string> Errors
#pragma warning restore RCS1085 // Use auto-implemented property.
        {
            get { return _Errors; }
            set { _Errors = value; }
        }

        public ModelValidationException(string message, List<string> error)
        {
            Message = message;
            _Errors = error;
        }
    }
}
