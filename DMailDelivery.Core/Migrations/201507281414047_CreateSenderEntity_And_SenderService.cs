namespace DMailDelivery.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSenderEntity_And_SenderService : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dmd.sender",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        emailaddress = c.String(),
                        password = c.String(),
                        smtpserver = c.String(),
                        port = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dmd.sender");
        }
    }
}
