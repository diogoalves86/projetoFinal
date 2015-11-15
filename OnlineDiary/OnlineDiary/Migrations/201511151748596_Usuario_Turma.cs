namespace OnlineDiary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Usuario_Turma : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Turma_Id", c => c.Int());
            CreateIndex("dbo.Users", "Turma_Id");
            AddForeignKey("dbo.Users", "Turma_Id", "dbo.Turmas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "Turma_Id", "dbo.Turmas");
            DropIndex("dbo.Usuarios", new[] { "Turma_Id" });
            DropColumn("dbo.Usuarios", "Turma_Id");
        }
    }
}
