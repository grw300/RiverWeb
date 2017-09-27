using JsonApiSerializer.JsonApi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RiverWeb.Models
{
    public class Department : BaseIdentifiable
    {
        public override string Type { get; set; } = "departments";

        public string Name { get; set; }
        public Guid? OwnerSiteId { get; set; }
        [JsonProperty(propertyName: "owner-site")]
        public Relationship<Site> OwnerSite { get; set; }
        public Relationship<IEnumerable<Personal>> Personnel { get; set; }
    }
}
