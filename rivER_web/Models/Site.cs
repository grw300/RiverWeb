using JsonApiSerializer.JsonApi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace rivER_web.Models
{
    public class Site : BaseIdentifiable
    {
        public override string Type { get; set; } = "sites";

        public string Name { get; set; }
        public Guid? OwnerOrganizationId { get; set; }
        [JsonProperty(propertyName: "owner-organization")]
        public Relationship<Organization> OwnerOrganization { get; set; }
        public Relationship<IEnumerable<Department>> Departments { get; set; }
    }
}
