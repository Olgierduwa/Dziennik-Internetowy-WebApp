namespace ProjektPiotrMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Przedmiots", "Nazwa", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Przedmiots", "Nazwa", c => c.String());
        }
    }
}
