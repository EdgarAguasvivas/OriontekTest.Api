using Microsoft.AspNetCore.Mvc.ModelBinding;
using OriontekTest.Api.Extensions;
using OriontekTest.Business.Exceptions;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OriontekTest.Api.Models
{
    [DataContract]
    public class ApiResponseVM
    {
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        public ApiResponseVM()
        {
        }

        public ApiResponseVM(string _message)
        {
            Message = _message;
        }
    }

    [DataContract]
    public class ApiResponseVM<T> : ApiResponseVM
    {
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public T Data { get; set; }

        public ApiResponseVM()
        {
        }

        public ApiResponseVM(string _message) : base(_message)
        {
        }

        public ApiResponseVM(string _message, T _data) : this(_message)
        {
            Data = _data;
        }
    }

    [DataContract]
    public class ApiErrorResponseVM : ApiResponseVM<ErrorsDictionary>
    {
        public ApiErrorResponseVM()
        {
        }

        public ApiErrorResponseVM(string _message) : base(_message)
        {
        }

        public ApiErrorResponseVM(string _message, ModelStateDictionary _modelState) : base(_message, new ErrorsDictionary(_modelState))
        {
        }
    }

    [DataContract]
    public class ErrorsDictionary
    {
        [DataMember(Name = "errors")]
        public Dictionary<string, string[]> Errors { get; set; }

        public ErrorsDictionary(ModelStateDictionary _modelState)
        {
            Errors = _modelState.GetErrorsDictionary();
        }
    }
}
