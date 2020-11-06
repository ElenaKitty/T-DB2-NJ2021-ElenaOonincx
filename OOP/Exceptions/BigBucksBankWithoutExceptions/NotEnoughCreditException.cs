using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBankWithoutExceptions
{
    class NotEnoughCreditException : Exception
    {
        public NotEnoughCreditException()
            :base()
        {

        }
        public NotEnoughCreditException(string message)
            :base(message)
        {

        }
    }
}
