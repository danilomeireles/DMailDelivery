using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMailDelivery.Core.Entity
{
    [Table("email", Schema = "dmd")]
    public class Email
    {
        [Key]        
        public int Id { get; set; }
        
        public virtual Application Application { get; set; }

        public virtual string Recipients { get; set; }
        
        public virtual string Subject { get; set; }
        
        public virtual string Message { get; set; }
        
        public virtual DateTime CriationDate { get; set; }
        
        public virtual DateTime? SendDate { get; set; }

        public virtual int Attempts { get; set; }
        
        public virtual string Error { get; set; }
    }
}
