using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriontekTest.Api.Models
{
    public class ErrorResponse
    {
        public CustomError CustomError { get; set; }
    }
    public class CustomError
    {
        public string Message { get; set; }
        public Error Error { get; set; }
    }

    public class Error
    {
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public int StatusCode { get; set; }
    }
}

