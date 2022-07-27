using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statusCde, string message = null, string details = null)
        {
            StatusCde = statusCde;
            Message = message;
            Details = details;
        }

        public int StatusCde { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }

    }
}