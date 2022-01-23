using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Exceptions
{
    class CustomException : Exception
    {
        public string ErrorClass { get; set; }
        public CustomException(string message, string errorclass)
            : base(message)
        {
            this.ErrorClass = errorclass;
        }
    }
}
