using InnoCLinic.OfficesAPI.Core.Contracts.Attributes;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace InnoCLinic.OfficesAPI.Core.Entities.Models
{
    [Collection("Office")]
    [BsonIgnoreExtraElements]
    public class Office : Document
    {
        [Required]
        [DataMember]
        [BsonElement("address")]
        public string Address { get; set; }
        [DataMember]
        [BsonElement("photoId")]
        public string PhotoId { get; set; }
        [DataMember]
        [BsonElement("url")]
        public string Url { get; set; }
        [Required]
        [DataMember]
        [BsonElement("registryPhoneNumber")]
        public string RegistryPhoneNumber { get; set; }
        [Required]
        [DataMember]
        [BsonElement("isActive")]
        public string IsActive { get; set; }
    }
}
