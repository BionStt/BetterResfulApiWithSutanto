using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.SalesMarketing.Domain.Exception
{
    public class InvalidDataKonsumenStateException : System.Exception
    {
        public InvalidDataKonsumenStateException(string message) : base(message)
        {

        }
    }
}
