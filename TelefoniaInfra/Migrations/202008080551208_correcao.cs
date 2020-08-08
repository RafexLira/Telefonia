namespace TelefoniaInfra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correcao : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Tipo", newName: "Servico");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Servico", newName: "Tipo");
        }
    }
}
