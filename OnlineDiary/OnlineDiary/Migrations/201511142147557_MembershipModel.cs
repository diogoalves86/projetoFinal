namespace OnlineDiary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Cpf = c.String(nullable: false),
                        Matricula = c.String(),
                        Email = c.String(),
                        Comment = c.String(),
                        IsApproved = c.Boolean(nullable: false),
                        LastLoginDate = c.DateTime(nullable: false),
                        LastActivityDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
