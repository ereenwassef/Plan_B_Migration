namespace NewDBModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerInfo", "NameEN", c => c.String(maxLength: 400));
            AddColumn("dbo.CustomerInfo", "NameAR", c => c.String(maxLength: 400));
            DropColumn("dbo.CustomerInfo", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerInfo", "Name", c => c.String(maxLength: 400));
            DropColumn("dbo.CustomerInfo", "NameAR");
            DropColumn("dbo.CustomerInfo", "NameEN");
        }
    }
}
