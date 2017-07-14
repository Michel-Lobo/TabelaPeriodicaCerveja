namespace TabelaCervejaAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criacao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EstiloCerveja",
                c => new
                    {
                        IDEstilo = c.Int(nullable: false, identity: true),
                        IDGrupoEstilo = c.Int(nullable: false),
                        NomeEstilo = c.String(),
                        DescricaoEstilo = c.String(),
                        GravidadeInicial = c.String(),
                        GravidadeFinal = c.String(),
                        IBU = c.String(),
                        ABV = c.String(),
                        SRM = c.String(),
                        Exemplos = c.String(),
                    })
                .PrimaryKey(t => t.IDEstilo)
                .ForeignKey("dbo.GrupoEstilo", t => t.IDGrupoEstilo, cascadeDelete: true)
                .Index(t => t.IDGrupoEstilo);
            
            CreateTable(
                "dbo.GrupoEstilo",
                c => new
                    {
                        IDGrupoEstilo = c.Int(nullable: false),
                        NomeGrupo = c.String(),
                    })
                .PrimaryKey(t => t.IDGrupoEstilo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EstiloCerveja", "IDGrupoEstilo", "dbo.GrupoEstilo");
            DropIndex("dbo.EstiloCerveja", new[] { "IDGrupoEstilo" });
            DropTable("dbo.GrupoEstilo");
            DropTable("dbo.EstiloCerveja");
        }
    }
}
