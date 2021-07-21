namespace LabBigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addupdate217 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Followings", "Course_Id", c => c.Int());
            CreateIndex("dbo.Followings", "Course_Id");
            AddForeignKey("dbo.Followings", "Course_Id", "dbo.Courses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Followings", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Followings", new[] { "Course_Id" });
            DropColumn("dbo.Followings", "Course_Id");
        }
    }
}
