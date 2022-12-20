namespace InnoCLinic.OfficesAPI.Core.Contracts.Settings
{
    public interface IOfficeStoreDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
