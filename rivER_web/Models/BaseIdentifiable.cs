using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace rivER_web.Models
{
    public abstract class BaseIdentifiable
    {
        public abstract string Type { get; set; }
        public Guid? Id { get; set; }

        public DateTime Created { get; set; }
    }
}
