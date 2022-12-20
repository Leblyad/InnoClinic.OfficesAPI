﻿using InnoCLinic.OfficesAPI.Core.Contracts.Attributes;
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
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string HouseNumber { get; set; }
        public string OfficeNumber { get; set; }
        public Guid PhotoId { get; set; }
        [Required]
        public string RegistryPhoneNumber { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
