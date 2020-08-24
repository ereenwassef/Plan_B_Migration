namespace NewDBModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v30 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerAttributes", "RenewalDateUtc", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerAttributes", "RenewalDateUtc");
        }
    }
}
