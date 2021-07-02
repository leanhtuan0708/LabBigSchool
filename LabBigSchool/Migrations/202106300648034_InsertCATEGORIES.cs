namespace LabBigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertCATEGORIES : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Id ,Name) VALUES (1, 'He Thong Thong tin')");
            Sql("INSERT INTO Categories (Id ,Name) VALUES (2, 'Cong Nghe Phan Mem')");
            Sql("INSERT INTO Categories (Id ,Name) VALUES (3, 'An Toan Thong Tin')");
        }
        
        public override void Down()
        {
        }
    }
}
