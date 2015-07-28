using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMailDelivery.Core.Entity
{
    [Table("sender", Schema = "dmd")]
    public class Sender
    {
        [Key]
        public int Id { get; set; }
        
        public string EmailAddress { get; set; }
		
        public string Password { get; set; }
		
        public string SmtpServer { get; set; }
		
        public int Port { get; set; }        
    }
}
