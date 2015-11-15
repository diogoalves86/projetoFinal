namespace OnlineDiary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DisciplinaModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Disciplina",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Disciplina");
        }
    }
}
