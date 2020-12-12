namespace OrgChartDotNetFW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Node", "responsibilities", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Node", "responsibilities");
        }
    }
}
