namespace KeepFit.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _int : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Weight", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Weight", c => c.Double(nullable: false));
        }
    }
}
