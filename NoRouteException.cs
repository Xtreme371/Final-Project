using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class NoRouteException : Exception
    {
        public NoRouteException()
        {
        }

        public NoRouteException(string message) : base(message)
        {
        }

        public NoRouteException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
