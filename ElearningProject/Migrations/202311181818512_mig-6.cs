namespace ElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carousels",
                c => new
                    {
                        CarouselID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ImageUrl = c.String(),
                        Text = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CarouselID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carousels");
        }
    }
}
