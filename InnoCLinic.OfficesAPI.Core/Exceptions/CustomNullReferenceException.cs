namespace InnoCLinic.OfficesAPI.Core.Exceptions
{
    public abstract class CustomNullReferenceException : NullReferenceException
    {
        protected CustomNullReferenceException(string message) : base(message)
        { }
    }
}
