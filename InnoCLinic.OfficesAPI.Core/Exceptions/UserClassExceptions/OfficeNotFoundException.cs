using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoCLinic.OfficesAPI.Core.Exceptions.UserClassExceptions
{
    public class OfficeNotFoundException : NotFoundException
    {
        public OfficeNotFoundException(ObjectId objectId) : base($"The office with the identifier {objectId.ToString()} was not found.")
        { }
    }
}
