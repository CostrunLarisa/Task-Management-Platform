namespace Task_Management_Platform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false),
                        DataAdaug = c.DateTime(nullable: false),
                        Task_TaskId = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Tasks", t => t.Task_TaskId)
                .Index(t => t.Task_TaskId);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(),
                        Status = c.String(),
                        DataStart = c.DateTime(nullable: false),
                        DataFin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TaskId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Task_TaskId", "dbo.Tasks");
            DropIndex("dbo.Comments", new[] { "Task_TaskId" });
            DropTable("dbo.Tasks");
            DropTable("dbo.Comments");
        }
    }
}
