namespace Job_Offers_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobBudget : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "JobBudget", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "JobBudget");
        }
    }
}
