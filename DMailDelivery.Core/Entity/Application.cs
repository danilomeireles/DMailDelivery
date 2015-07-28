using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMailDelivery.Core.Entity
{
    [Table("application", Schema = "dmd")]
    public class Application
    {
        [Key]
        public int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }
    }
}
