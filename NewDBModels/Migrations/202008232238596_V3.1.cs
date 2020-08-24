namespace NewDBModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V31 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerAttributes", "ActualRenewalDateUtc", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerAttributes", "ActualRenewalDateUtc");
        }
    }
}
