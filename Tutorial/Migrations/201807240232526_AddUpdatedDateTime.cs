namespace Tutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUpdatedDateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "updatedDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "updatedDateTime");
        }
    }
}
