using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoCLinic.OfficesAPI.Core.Exceptions.UserClassExceptions
{
    public class OfficeNullReferenceException : CustomNullReferenceException
    {
        public OfficeNullReferenceException(Type type) : base($"Object of type: {type.Name} is null.")
        { }
    }
}
