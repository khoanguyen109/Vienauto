using System;
using System.Collections.Generic;

namespace Vienauto.Service.Result
{
    public class Error
    {
        public ErrorCode Code { get; set; }
        public Exception Exception { get; set; }

        public Error()
        {
            Code = ErrorCode.None;
            Exception = null;
        }

        public Error(ErrorCode code, Exception exception)
        {
            Code = code;
            Exception = exception;
        }
    }

    public class ErrorHelper
    {
        public List<Error> Errors { get; set; }

        public ErrorHelper()
        {
            Errors = new List<Error>();
        }

        public List<Error> AddErrorRange(IEnumerable<Error> ErrorsRange)
        {
            Errors.AddRange(ErrorsRange);
            return Errors;
        }

        public List<Error> AddError(ErrorCode error, Exception exception)
        {
            Errors.Add(new Error { Code = error, Exception = exception });
            return Errors;
        }

        public List<Error> AddError(ErrorCode error)
        {
            return AddError(error, null);
        }

        public List<Error> AddError(Exception exception)
        {
            return AddError(ErrorCode.None, exception);
        }
    }
}
