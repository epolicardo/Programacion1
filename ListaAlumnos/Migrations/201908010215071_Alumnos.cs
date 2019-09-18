namespace ListaAlumnos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alumnos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NroMatricula = c.String(),
                        persona_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personas", t => t.persona_Id)
                .Index(t => t.persona_Id);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DNI = c.String(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumnos", "persona_Id", "dbo.Personas");
            DropIndex("dbo.Alumnos", new[] { "persona_Id" });
            DropTable("dbo.Personas");
            DropTable("dbo.Alumnos");
        }
    }
}
