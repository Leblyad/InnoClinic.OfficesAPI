﻿using InnoCLinic.OfficesAPI.Core.Contracts.Attributes;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InnoCLinic.OfficesAPI.Core.Entities.Models
{
    [Collection("Office")]
    [BsonIgnoreExtraElements]
    public class Office : Document
    {
        [DataMember]
        [BsonElement("address")]
        public string Address { get; set; }
        [DataMember]
        [BsonElement("photoId")]
        public string PhotoId { get; set; }
        [DataMember]
        [BsonElement("url")]
        public string Url { get; set; }
        [DataMember]
        [BsonElement("registryPhoneNumber")]
        public string RegistryPhoneNumber { get; set; }
        [DataMember]
        [BsonElement("isActive")]
        public string IsActive { get; set; }
    }
}
