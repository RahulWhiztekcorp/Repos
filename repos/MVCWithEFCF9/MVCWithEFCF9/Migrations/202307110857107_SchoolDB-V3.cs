namespace MVCWithEFCF9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchoolDBV3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "Fees");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Fees", c => c.Single(nullable: false));
        }
    }
}
