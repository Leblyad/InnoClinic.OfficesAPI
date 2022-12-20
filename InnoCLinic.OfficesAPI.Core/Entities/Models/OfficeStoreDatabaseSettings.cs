using InnoCLinic.OfficesAPI.Core.Contracts.Settings;

namespace InnoCLinic.OfficesAPI.Core.Entities.Models
{
    public class OfficeStoreDatabaseSettings : IOfficeStoreDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
