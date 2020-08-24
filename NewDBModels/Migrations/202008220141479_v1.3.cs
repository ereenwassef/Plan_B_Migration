namespace NewDBModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v13 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerInfo", "Mobile", c => c.String());
            AlterColumn("dbo.CustomerInfo", "NationalId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerInfo", "NationalId", c => c.String(maxLength: 20));
            AlterColumn("dbo.CustomerInfo", "Mobile", c => c.String(maxLength: 20));
        }
    }
}
