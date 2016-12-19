namespace WindowsOpendeurdagAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial14 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GebruikerFormuliers", "Geboortedatum", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GebruikerFormuliers", "Geboortedatum", c => c.DateTime(nullable: false));
        }
    }
}
