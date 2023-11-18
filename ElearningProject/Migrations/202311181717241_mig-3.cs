namespace ElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        CommentText = c.String(),
                        CommentTime = c.DateTime(nullable: false),
                        CommentStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Comments");
        }
    }
}
