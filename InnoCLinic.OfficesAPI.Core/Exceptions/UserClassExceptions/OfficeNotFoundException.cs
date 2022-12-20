using MongoDB.Bson;

namespace InnoCLinic.OfficesAPI.Core.Exceptions.UserClassExceptions
{
    public class OfficeNotFoundException : NotFoundException
    {
        public OfficeNotFoundException(ObjectId objectId) : base($"The office with the identifier {objectId} was not found.")
        { }
    }
}
