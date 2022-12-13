namespace InnoCLinic.OfficesAPI.Core.Exceptions.UserClassExceptions
{
    public class OfficeNullReferenceException : CustomNullReferenceException
    {
        public OfficeNullReferenceException(Type type) : base($"Object of type: {type.Name} is null.")
        { }
    }
}
