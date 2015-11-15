namespace OnlineDiary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Usuario_Disciplina : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario_Disciplinas",
                c => new
                    {
                        Usuario_Id = c.Guid(nullable: false),
                        Disciplina_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Usuario_Id, t.Disciplina_Id })
                .ForeignKey("dbo.Disciplinas", t => t.Disciplina_Id, cascadeDelete: true)
                .Index(t => t.Usuario_Id)
                .Index(t => t.Disciplina_Id);
            AddForeignKey("dbo.Usuario_Disciplinas", "Usuario_Id", "dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario_Disciplinas", "Disciplina_Id", "dbo.Disciplinas");
            DropForeignKey("dbo.Usuario_Disciplinas", "Usuario_Id", "dbo.Users");
            DropIndex("dbo.Usuario_Disciplinas", new[] { "Disciplina_Id" });
            DropIndex("dbo.Usuario_Disciplinas", new[] { "Usuario_Id" });
            DropTable("dbo.Usuario_Disciplinas");
        }
    }
}
