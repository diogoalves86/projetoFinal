namespace OnlineDiary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Notas_Usuario_Disciplina : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notas", "disciplina_Id", c => c.Int());
            AddColumn("dbo.Notas", "usuario_Id", c => c.Guid());
            CreateIndex("dbo.Notas", "disciplina_Id");
            CreateIndex("dbo.Notas", "usuario_Id");
            AddForeignKey("dbo.Notas", "disciplina_Id", "dbo.Disciplinas", "Id");
            AddForeignKey("dbo.Notas", "usuario_Id", "dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notas", "usuario_Id", "dbo.Users");
            DropForeignKey("dbo.Notas", "disciplina_Id", "dbo.Disciplinas");
            DropIndex("dbo.Notas", new[] { "usuario_Id" });
            DropIndex("dbo.Notas", new[] { "disciplina_Id" });
            DropColumn("dbo.Notas", "usuario_Id");
            DropColumn("dbo.Notas", "disciplina_Id");
        }
    }
}
