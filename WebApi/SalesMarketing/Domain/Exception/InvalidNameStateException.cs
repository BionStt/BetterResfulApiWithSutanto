using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.SalesMarketing.Domain.Exception
{
    public class InvalidNameStateException: System.Exception
    {
        public InvalidNameStateException(string message) : base(message)
        {

        }
    }
}
