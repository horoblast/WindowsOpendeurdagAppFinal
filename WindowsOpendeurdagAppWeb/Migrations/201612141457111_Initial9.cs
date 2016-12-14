namespace WindowsOpendeurdagAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Campus", "GebruikerFormulier_GebruikerFormulierId", "dbo.GebruikerFormuliers");
            DropForeignKey("dbo.Richtings", "GebruikerFormulier_GebruikerFormulierId", "dbo.GebruikerFormuliers");
            DropIndex("dbo.Campus", new[] { "GebruikerFormulier_GebruikerFormulierId" });
            DropIndex("dbo.Richtings", new[] { "GebruikerFormulier_GebruikerFormulierId" });
            AddColumn("dbo.GebruikerFormuliers", "Campus_CampusId", c => c.Int());
            AddColumn("dbo.GebruikerFormuliers", "Richting_RichtingId", c => c.Int());
            CreateIndex("dbo.GebruikerFormuliers", "Campus_CampusId");
            CreateIndex("dbo.GebruikerFormuliers", "Richting_RichtingId");
            AddForeignKey("dbo.GebruikerFormuliers", "Campus_CampusId", "dbo.Campus", "CampusId");
            AddForeignKey("dbo.GebruikerFormuliers", "Richting_RichtingId", "dbo.Richtings", "RichtingId");
            DropColumn("dbo.Campus", "GebruikerFormulier_GebruikerFormulierId");
            DropColumn("dbo.Richtings", "GebruikerFormulier_GebruikerFormulierId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Richtings", "GebruikerFormulier_GebruikerFormulierId", c => c.Int());
            AddColumn("dbo.Campus", "GebruikerFormulier_GebruikerFormulierId", c => c.Int());
            DropForeignKey("dbo.GebruikerFormuliers", "Richting_RichtingId", "dbo.Richtings");
            DropForeignKey("dbo.GebruikerFormuliers", "Campus_CampusId", "dbo.Campus");
            DropIndex("dbo.GebruikerFormuliers", new[] { "Richting_RichtingId" });
            DropIndex("dbo.GebruikerFormuliers", new[] { "Campus_CampusId" });
            DropColumn("dbo.GebruikerFormuliers", "Richting_RichtingId");
            DropColumn("dbo.GebruikerFormuliers", "Campus_CampusId");
            CreateIndex("dbo.Richtings", "GebruikerFormulier_GebruikerFormulierId");
            CreateIndex("dbo.Campus", "GebruikerFormulier_GebruikerFormulierId");
            AddForeignKey("dbo.Richtings", "GebruikerFormulier_GebruikerFormulierId", "dbo.GebruikerFormuliers", "GebruikerFormulierId");
            AddForeignKey("dbo.Campus", "GebruikerFormulier_GebruikerFormulierId", "dbo.GebruikerFormuliers", "GebruikerFormulierId");
        }
    }
}
