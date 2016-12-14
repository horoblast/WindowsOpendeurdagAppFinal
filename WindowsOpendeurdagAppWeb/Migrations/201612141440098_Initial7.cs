namespace WindowsOpendeurdagAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.GebruikerFormuliers", "Gsmnr");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GebruikerFormuliers", "Gsmnr", c => c.Int(nullable: false));
        }
    }
}
