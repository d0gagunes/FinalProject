using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        private string productNameInvalid;

        public Result(bool success, string message) : this (success)
        {
            Message = message;
            
        }

      
        public Result(bool success)
        {
            Success = success;
        }

        public Result(string productNameInvalid)
        {
            this.productNameInvalid = productNameInvalid;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
