namespace ElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServicesID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ServicesID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Services");
        }
    }
}
