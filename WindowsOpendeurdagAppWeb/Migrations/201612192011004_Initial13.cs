namespace WindowsOpendeurdagAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial13 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GebruikerFormuliers", "Campus_CampusId", "dbo.Campus");
            DropForeignKey("dbo.GebruikerFormuliers", "Richting_RichtingId", "dbo.Richtings");
            DropIndex("dbo.GebruikerFormuliers", new[] { "Campus_CampusId" });
            DropIndex("dbo.GebruikerFormuliers", new[] { "Richting_RichtingId" });
            AddColumn("dbo.GebruikerFormuliers", "Campus", c => c.String());
            AddColumn("dbo.GebruikerFormuliers", "Richting", c => c.String());
            DropColumn("dbo.GebruikerFormuliers", "Campus_CampusId");
            DropColumn("dbo.GebruikerFormuliers", "Richting_RichtingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GebruikerFormuliers", "Richting_RichtingId", c => c.Int());
            AddColumn("dbo.GebruikerFormuliers", "Campus_CampusId", c => c.Int());
            DropColumn("dbo.GebruikerFormuliers", "Richting");
            DropColumn("dbo.GebruikerFormuliers", "Campus");
            CreateIndex("dbo.GebruikerFormuliers", "Richting_RichtingId");
            CreateIndex("dbo.GebruikerFormuliers", "Campus_CampusId");
            AddForeignKey("dbo.GebruikerFormuliers", "Richting_RichtingId", "dbo.Richtings", "RichtingId");
            AddForeignKey("dbo.GebruikerFormuliers", "Campus_CampusId", "dbo.Campus", "CampusId");
        }
    }
}
