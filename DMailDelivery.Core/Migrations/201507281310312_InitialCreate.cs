namespace DMailDelivery.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dmd.application",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dmd.email",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        recipients = c.String(),
                        subject = c.String(),
                        message = c.String(),
                        criationdate = c.DateTime(nullable: false),
                        senddate = c.DateTime(),
                        attempts = c.Int(nullable: false),
                        error = c.String(),
                        application_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dmd.application", t => t.application_id)
                .Index(t => t.application_id, name: "IX_Application_Id");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dmd.email", "application_id", "dmd.application");
            DropIndex("dmd.email", "IX_Application_Id");
            DropTable("dmd.email");
            DropTable("dmd.application");
        }
    }
}
