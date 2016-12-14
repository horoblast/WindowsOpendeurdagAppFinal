namespace WindowsOpendeurdagAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gebouws", "Afkorting", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gebouws", "Afkorting");
        }
    }
}
