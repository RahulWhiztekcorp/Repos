namespace MVCWithEFCF9.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class SchoolDBV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Class = c.Int(nullable: false),
                        Section = c.String(maxLength: 1, unicode: false),
                        Fees = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
