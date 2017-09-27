using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace RiverWeb.Models
{
    public abstract class BaseIdentifiable
    {
        public abstract string Type { get; set; }
        public Guid? Id { get; set; }

        public DateTime Created { get; set; }
    }
}
