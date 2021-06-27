namespace Job_Offers_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ACtive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "ACtive", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "ACtive");
        }
    }
}
