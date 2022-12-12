using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoCLinic.OfficesAPI.Core.Exceptions
{
    public abstract class CustomNullReferenceException : NullReferenceException
    {
        protected CustomNullReferenceException(string message) : base(message)
        { }
    }
}
