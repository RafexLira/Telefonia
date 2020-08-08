namespace TelefoniaInfra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class novo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Operadora",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeOperadora = c.String(nullable: false, maxLength: 10),
                        DDD = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Plano",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomePlano = c.String(nullable: false, maxLength: 30),
                        OperadoraId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Operadora", t => t.OperadoraId, cascadeDelete: true)
                .Index(t => t.OperadoraId);
            
            CreateTable(
                "dbo.Tipo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeServico = c.String(nullable: false, maxLength: 60),
                        Franquia = c.String(nullable: false, maxLength: 60),
                        Minutos = c.Int(nullable: false),
                        OutrasOperadoras = c.String(nullable: false, maxLength: 10),
                        Preco = c.Double(nullable: false),
                        PlanoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Plano", t => t.PlanoId, cascadeDelete: true)
                .Index(t => t.PlanoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tipo", "PlanoId", "dbo.Plano");
            DropForeignKey("dbo.Plano", "OperadoraId", "dbo.Operadora");
            DropIndex("dbo.Tipo", new[] { "PlanoId" });
            DropIndex("dbo.Plano", new[] { "OperadoraId" });
            DropTable("dbo.Tipo");
            DropTable("dbo.Plano");
            DropTable("dbo.Operadora");
        }
    }
}
