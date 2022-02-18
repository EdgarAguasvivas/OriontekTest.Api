using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using OriontekTest.Api.Models;
using OriontekTest.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security;
using System.Threading.Tasks;

namespace OriontekTest.Api.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                
                await next(context).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex).ConfigureAwait(false);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var code = HttpStatusCode.InternalServerError;
            var message = "Ocurrió un error inesperado.";

            ErrorResponse errorResult;

            if (exception is SecurityException)
            {
                message = ErrorMessages.SecurityException;
                code = HttpStatusCode.Unauthorized;
            }
            else if (exception is ArgumentException)
            {
                message = ErrorMessages.ArgumentException;
                
                code = HttpStatusCode.BadRequest;
            }
            else if (exception is ArgumentNullException)
            {
                message = ErrorMessages.ArgumentNullException;

                code = HttpStatusCode.BadRequest;
            }
            else if (exception is NotFoundException)
            {
                message = ErrorMessages.NotFoundExection;
               
                code = HttpStatusCode.NotFound;
            }
            else if (exception is ProfileNotFoundException)
            {
                message = ErrorMessages.ProfileNotFoundException;
             
                code = HttpStatusCode.BadRequest;
            }
            else if (exception is UriFormatException)
            {
                message = ErrorMessages.UriFormatException;
              
                code = HttpStatusCode.BadRequest;
            }
            else if (exception is HttpRequestException)
            {
                message = ErrorMessages.HttpRequestException;
               
                code = HttpStatusCode.BadRequest;
            }
            else if (exception is AuthorizationValidationException)
            {
                message = ErrorMessages.AuthorizationValidationException;
               
                code = HttpStatusCode.Unauthorized;
            }

            var responseModel = new ApiErrorResponseVM()
            {
                Message = message
            };

            errorResult = new ErrorResponse
            {
                CustomError = new CustomError
                {
                    Message = message,
                    Error = new Error
                    {
                        Message = exception.Message,
                        StatusCode = (int)code
                    }
                }
            };

            var result = JsonConvert.SerializeObject(errorResult);
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(result);
        }
    }
}
